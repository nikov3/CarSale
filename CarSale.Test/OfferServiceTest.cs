using NUnit.Framework;
using Moq;
using CarSale.Core.Services;
using CarSale.Core.Models.Offer;
using CarSale.Core.Contracts;
using CarSale.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;

namespace CarSale.Tests.Services
{
    [TestFixture]
    public class OfferServiceTests
    {
        private OfferService _offerService;
        private Mock<IRepository> _repositoryMock;

        [SetUp]
        public void Setup()
        {
            _repositoryMock = new Mock<IRepository>();
            _offerService = new OfferService(_repositoryMock.Object);
        }
        #region AllBrandsNamesAsync Tests
        [Test]
        public async Task AllBrandsNamesAsync_Returns_Correct_Brand_Names()
        {
            // Arrange
            var expectedBrandNames = new List<string> { "Brand1", "Brand2", "Brand3" };
            _repositoryMock.Setup(repo => repo.AllReadOnly<Brand>()).Returns(new TestAsyncEnumerable<Brand>(GetTestBrands().AsQueryable()));

            // Act
            var result = await _offerService.AllBrandsNamesAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedBrandNames.Count()));
            Assert.That(result, Is.EqualTo(expectedBrandNames));
        }
        #endregion

        #region AllFuelsNamesAsync Tests
        [Test]
        public async Task AllFuelsNamesAsync_Returns_Correct_Fuel_Names()
        {
            // Arrange
            var expectedFuelNames = new List<string> { "Fuel1", "Fuel2", "Fuel3" };
            _repositoryMock.Setup(repo => repo.AllReadOnly<Fuel>()).Returns(new TestAsyncEnumerable<Fuel>(GetTestFuels().AsQueryable()));

            // Act
            var result = await _offerService.AllFuelsNamesAsync();

            // Assert
            Assert.AreEqual(expectedFuelNames.Count(), result.Count());
            Assert.AreEqual(expectedFuelNames, result);
        }
        #endregion

        // Repeat similar tests for other methods...

        #region Test Data
        private List<Offer> GetTestOffers()
        {
            return new List<Offer>
            {
                new Offer { Id = 1, CarModel = "Model1", IsApproved = true },
                new Offer { Id = 2, CarModel = "Model2", IsApproved = true },
                new Offer { Id = 3, CarModel = "Model3", IsApproved = true },
                new Offer { Id = 4, CarModel = "Model4", IsApproved = true },
                new Offer { Id = 5, CarModel = "Model5", IsApproved = true }
            };
        }

        private List<Brand> GetTestBrands()
        {
            return new List<Brand>
            {
                new Brand { Id = 1, Name = "Brand1" },
                new Brand { Id = 2, Name = "Brand2" },
                new Brand { Id = 3, Name = "Brand3" }
            };
        }

        private List<Fuel> GetTestFuels()
        {
            return new List<Fuel>
            {
                new Fuel { Id = 1, Name = "Fuel1" },
                new Fuel { Id = 2, Name = "Fuel2" },
                new Fuel { Id = 3, Name = "Fuel3" }
            };
        }

        // Repeat for other test data...
        #endregion

        #region AllTransmissionsNamesAsync Tests
        [Test]
        public async Task AllTransmissionsNamesAsync_Returns_Correct_Transmission_Names()
        {
            // Arrange
            var expectedTransmissionNames = new List<string> { "Transmission1", "Transmission2", "Transmission3" };
            _repositoryMock.Setup(repo => repo.AllReadOnly<Transmission>()).Returns(new TestAsyncEnumerable<Transmission>(GetTestTransmissions().AsQueryable()));

            // Act
            var result = await _offerService.AllTransmissionsNamesAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedTransmissionNames.Count()));
            Assert.That(result, Is.EqualTo(expectedTransmissionNames));
        }
        #endregion

        #region AllCarTypesNamesAsync Tests
        [Test]
        public async Task AllCarTypesNamesAsync_Returns_Correct_CarType_Names()
        {
            // Arrange
            var expectedCarTypeNames = new List<string> { "CarType1", "CarType2", "CarType3" };
            _repositoryMock.Setup(repo => repo.AllReadOnly<CarType>()).Returns(new TestAsyncEnumerable<CarType>(GetTestCarTypes().AsQueryable()));

            // Act
            var result = await _offerService.AllCarTypesNamesAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedCarTypeNames.Count()));
            Assert.That(result, Is.EqualTo(expectedCarTypeNames));
        }
        #endregion

        #region AllColorsNamesAsync Tests
        [Test]
        public async Task AllColorsNamesAsync_Returns_Correct_Color_Names()
        {
            // Arrange
            var expectedColorNames = new List<string> { "Color1", "Color2", "Color3" };
            _repositoryMock.Setup(repo => repo.AllReadOnly<Color>()).Returns(new TestAsyncEnumerable<Color>(GetTestColors().AsQueryable()));

            // Act
            var result = await _offerService.AllColorsNamesAsync();

            // Assert
            Assert.AreEqual(expectedColorNames.Count(), result.Count());
            Assert.AreEqual(expectedColorNames, result);
        }
        #endregion

        #region AllCitiesNamesAsync Tests
        [Test]
        public async Task AllCitiesNamesAsync_Returns_Correct_City_Names()
        {
            // Arrange
            var expectedCityNames = new List<string> { "City1", "City2", "City3" };
            _repositoryMock.Setup(repo => repo.AllReadOnly<City>()).Returns(new TestAsyncEnumerable<City>(GetTestCities().AsQueryable()));

            // Act
            var result = await _offerService.AllCitiesNamesAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedCityNames.Count()));
            Assert.That(result, Is.EqualTo(expectedCityNames));
        }
        #endregion

        #region AllBrandsAsync Tests
        [Test]
        public async Task AllBrandsAsync_Returns_Correct_Brand_Service_Models()
        {
            // Arrange
            var expectedBrands = GetTestBrands().Select(b => new OfferBrandServiceModel { Id = b.Id, Name = b.Name }).ToList();
            _repositoryMock.Setup(repo => repo.AllReadOnly<Brand>()).Returns(new TestAsyncEnumerable<Brand>(GetTestBrands().AsQueryable()));

            // Act
            var result = await _offerService.AllBrandsAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedBrands.Count()));
            Assert.That(result.First().Id, Is.EqualTo(expectedBrands.First().Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedBrands.First().Name));
        }
        #endregion

        // Repeat similar tests for other methods...

        #region Test Data
        private List<Transmission> GetTestTransmissions()
        {
            return new List<Transmission>
            {
                new Transmission { Id = 1, Name = "Transmission1" },
                new Transmission { Id = 2, Name = "Transmission2" },
                new Transmission { Id = 3, Name = "Transmission3" }
            };
        }

        private List<CarType> GetTestCarTypes()
        {
            return new List<CarType>
            {
                new CarType { Id = 1, Name = "CarType1" },
                new CarType { Id = 2, Name = "CarType2" },
                new CarType { Id = 3, Name = "CarType3" }
            };
        }

        private List<Color> GetTestColors()
        {
            return new List<Color>
            {
                new Color { Id = 1, Name = "Color1" },
                new Color { Id = 2, Name = "Color2" },
                new Color { Id = 3, Name = "Color3" }
            };
        }

        private List<City> GetTestCities()
        {
            return new List<City>
            {
                new City { Id = 1, Name = "City1" },
                new City { Id = 2, Name = "City2" },
                new City { Id = 3, Name = "City3" }
            };
        }
        #endregion

    }
}