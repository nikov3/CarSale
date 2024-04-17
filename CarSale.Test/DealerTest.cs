using CarSale.Core.Services;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;
using Moq;

namespace CarSale.Tests.Services
{
    public class DealerTest
    {
        private DealerService _dealerService;
        private Mock<IRepository> _repositoryMock;

        [SetUp]
        public void Setup()
        {
            _repositoryMock = new Mock<IRepository>();
            _dealerService = new DealerService(_repositoryMock.Object);
        }

        [Test]
        public async Task CreateAsync_ShouldAddDealer()
        {
            var userId = "userId";
            var phoneNumber = "phoneNumber";

            await _dealerService.CreateAsync(userId, phoneNumber);

            _repositoryMock.Verify(r => r.AddAsync(It.Is<Dealer>(d => d.UserId == userId && d.PhoneNumber == phoneNumber)), Times.Once);
            _repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }
        [Test]
        public async Task ExistsByIdAsync_ShouldReturnTrue_WhenDealerExists()
        {
            var userId = "userId";
            var dealerList = new List<Dealer> { new Dealer { UserId = userId } };
            _repositoryMock.Setup(r => r.AllReadOnly<Dealer>()).Returns(new TestAsyncEnumerable<Dealer>(dealerList).AsQueryable());

            var result = await _dealerService.ExistsByIdAsync(userId);

            Assert.True(result);
            _repositoryMock.Verify(r => r.AllReadOnly<Dealer>(), Times.Once);
        }
        [Test]
        public async Task GetDealerIdAsync_ShouldReturnDealerId_WhenDealerExists()
        {
            var userId = "userId";
            var dealerList = new List<Dealer> { new Dealer { UserId = userId, Id = 1 } };
            _repositoryMock.Setup(r => r.AllReadOnly<Dealer>()).Returns(new TestAsyncEnumerable<Dealer>(dealerList).AsQueryable());

            var result = await _dealerService.GetDealerIdAsync(userId);

            Assert.That(result, Is.EqualTo(1));
            _repositoryMock.Verify(r => r.AllReadOnly<Dealer>(), Times.Once);
        }
        [Test]
        public async Task UserWithPhoneNumberExistsAsync_ShouldReturnTrue_WhenDealerExists()
        {
            var phoneNumber = "phoneNumber";
            var dealerList = new List<Dealer> { new Dealer { PhoneNumber = phoneNumber } };
            _repositoryMock.Setup(r => r.AllReadOnly<Dealer>()).Returns(new TestAsyncEnumerable<Dealer>(dealerList).AsQueryable());

            var result = await _dealerService.UserWithPhoneNumberExistsAsync(phoneNumber);

            Assert.True(result);
            _repositoryMock.Verify(r => r.AllReadOnly<Dealer>(), Times.Once);
        }
    }
}