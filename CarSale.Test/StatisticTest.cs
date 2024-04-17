using CarSale.Core.Models.Satistics;
using CarSale.Core.Services;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;
using Moq;
using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Test
{
    internal class StatisticTest
    {
        private StatisticService _statisticService;
        private Mock<IRepository> _repositoryMock;

        [SetUp]
        public void Setup()
        {
            _repositoryMock = new Mock<IRepository>();
            _statisticService = new StatisticService(_repositoryMock.Object);
        }

        //public async Task<StatisticServiceModel> TotalAsync()
        //{
        //    int totalOffers = await repository.AllReadOnly<Offer>()
        //    .Where(o => o.IsApproved)
        //        .CountAsync();
        //    int totalDealers = await repository.AllReadOnly<Dealer>()
        //        .CountAsync();

        //    return new StatisticServiceModel
        //    {
        //        TotalOffers = totalOffers,
        //        TotalDealers = totalDealers
        //    };
        //}

        [Test]
        public async Task TotalAsync_ShouldReturnCorrectStatistic()
        {
            // Arrange
            var offers = new List<Offer>
            {
                new Offer { IsApproved = true },
                new Offer { IsApproved = true },
                new Offer { IsApproved = false }
            };
            var dealers = new List<Dealer>
            {
                new Dealer(),
                new Dealer()
            };
            _repositoryMock.Setup(r => r.AllReadOnly<Offer>()).Returns(new TestAsyncEnumerable<Offer>(offers).AsQueryable());
            _repositoryMock.Setup(r => r.AllReadOnly<Dealer>()).Returns(new TestAsyncEnumerable<Dealer>(dealers).AsQueryable());

            // Act
            var result = await _statisticService.TotalAsync();

            // Assert
            Assert.That(result.TotalOffers, Is.EqualTo(2));
            Assert.That(result.TotalDealers, Is.EqualTo(2));
            _repositoryMock.Verify(r => r.AllReadOnly<Offer>(), Times.Once);
            _repositoryMock.Verify(r => r.AllReadOnly<Dealer>(), Times.Once);
        }

        [Test]
        public async Task TotalAsync_ShouldReturnZero_WhenNoOffers()
        {
            // Arrange
            var offers = new List<Offer>();
            var dealers = new List<Dealer>();
            _repositoryMock.Setup(r => r.AllReadOnly<Offer>()).Returns(new TestAsyncEnumerable<Offer>(offers).AsQueryable());
            _repositoryMock.Setup(r => r.AllReadOnly<Dealer>()).Returns(new TestAsyncEnumerable<Dealer>(dealers).AsQueryable());

            // Act
            var result = await _statisticService.TotalAsync();

            // Assert
            Assert.That(result.TotalOffers, Is.EqualTo(0));
            Assert.That(result.TotalDealers, Is.EqualTo(0));
            _repositoryMock.Verify(r => r.AllReadOnly<Offer>(), Times.Once);
            _repositoryMock.Verify(r => r.AllReadOnly<Dealer>(), Times.Once);
        }

        [Test]
        public async Task TotalAsync_ShouldReturnZero_WhenNoDealers()
        {
            // Arrange
            var offers = new List<Offer>
            {
                new Offer { IsApproved = true }
            };
            var dealers = new List<Dealer>();
            _repositoryMock.Setup(r => r.AllReadOnly<Offer>()).Returns(new TestAsyncEnumerable<Offer>(offers).AsQueryable());
            _repositoryMock.Setup(r => r.AllReadOnly<Dealer>()).Returns(new TestAsyncEnumerable<Dealer>(dealers).AsQueryable());

            // Act
            var result = await _statisticService.TotalAsync();

            // Assert
            Assert.That(result.TotalOffers, Is.EqualTo(1));
            Assert.That(result.TotalDealers, Is.EqualTo(0));
            _repositoryMock.Verify(r => r.AllReadOnly<Offer>(), Times.Once);
            _repositoryMock.Verify(r => r.AllReadOnly<Dealer>(), Times.Once);
        }
    }
}