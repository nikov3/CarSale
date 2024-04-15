using CarSale.Core.Models;
using CarSale.Core.Services;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

public class OfferServiceTests
{
    private Mock<IRepository> repositoryMock;
    private OfferService offerService;

    [SetUp]
    public void Setup()
    {
        repositoryMock = new Mock<IRepository>();
        offerService = new OfferService(repositoryMock.Object);
    }

    [Test]
    public async Task AllBrandsAsync_ShouldReturnAllBrands()
    {
        // Arrange
        var brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "Brand1" },
            new Brand { Id = 2, Name = "Brand2" }
        };

        repositoryMock.Setup(r => r.AllReadOnly<Brand>())
            .Returns(new TestAsyncEnumerable<Brand>(brands));

        // Act
        var result = await offerService.AllBrandsAsync();

        // Assert
        Assert.That(result.Count(), Is.EqualTo(2));
        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Brand1"));
        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Brand2"));
    }

    [Test]
    public async Task AllCarTypesAsync_ShouldReturnAllCarTypes()
    {
        // Arrange
        var carTypes = new List<CarType>
        {
            new CarType { Id = 1, Name = "CarType1" },
            new CarType { Id = 2, Name = "CarType2" },
        };

        repositoryMock.Setup(r => r.AllReadOnly<CarType>())
            .Returns(new TestAsyncEnumerable<CarType>(carTypes));

        // Act
        var result = await offerService.AllCarTypesAsync();

        // Assert
        Assert.That(result.Count(), Is.EqualTo(2));
        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
        Assert.That(result.ElementAt(0).Name, Is.EqualTo("CarType1"));
        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
        Assert.That(result.ElementAt(1).Name, Is.EqualTo("CarType2"));
    }

    [Test]
    public async Task AllCitiesAsync_ShouldReturnAllCities()
    {
        // Arrange
        var cities = new List<City>
        {
            new City { Id = 1, Name = "City1" },
            new City { Id = 2, Name = "City2" },
        };

        repositoryMock.Setup(r => r.AllReadOnly<City>())
            .Returns(new TestAsyncEnumerable<City>(cities));

        // Act
        var result = await offerService.AllCitiesAsync();

        // Assert
        Assert.That(result.Count(), Is.EqualTo(2));
        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
        Assert.That(result.ElementAt(0).Name, Is.EqualTo("City1"));
        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
        Assert.That(result.ElementAt(1).Name, Is.EqualTo("City2"));
    }

    [Test]
    public async Task AllColorsAsync_ShouldReturnAllColors()
    {
        // Arrange
        var colors = new List<Color>
        {
            new Color { Id = 1, Name = "Color1" },
            new Color { Id = 2, Name = "Color2" },
        };

        repositoryMock.Setup(r => r.AllReadOnly<Color>())
            .Returns(new TestAsyncEnumerable<Color>(colors));

        // Act
        var result = await offerService.AllColorsAsync();

        // Assert
        Assert.That(result.Count(), Is.EqualTo(2));
        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Color1"));
        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Color2"));
    }

    [Test]
    public async Task AllFuelsAsync_ShouldReturnAllFuels()
    {
        // Arrange
        var fuels = new List<Fuel>
        {
            new Fuel { Id = 1, Name = "Fuel1" },
            new Fuel { Id = 2, Name = "Fuel2" },
        };

        repositoryMock.Setup(r => r.AllReadOnly<Fuel>())
            .Returns(new TestAsyncEnumerable<Fuel>(fuels));

        // Act
        var result = await offerService.AllFuelsAsync();

        // Assert
        Assert.That(result.Count(), Is.EqualTo(2));
        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Fuel1"));
        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Fuel2"));
    }

    [Test]
    public async Task AllTransmissionsAsync_ShouldReturnAllTransmissions()
    {
        // Arrange
        var transmissions = new List<Transmission>
        {
            new Transmission { Id = 1, Name = "Transmission1" },
            new Transmission { Id = 2, Name = "Transmission2" },
        };

        repositoryMock.Setup(r => r.AllReadOnly<Transmission>())
            .Returns(new TestAsyncEnumerable<Transmission>(transmissions));

        // Act
        var result = await offerService.AllTransmissionsAsync();

        // Assert
        Assert.That(result.Count(), Is.EqualTo(2));
        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Transmission1"));
        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Transmission2"));
    }
}


//using CarSale.Core.Models;
//using CarSale.Core.Services;
//using CarSale.Data.Models;
//using CarSale.Infrastructure.Data.Common;
//using Microsoft.EntityFrameworkCore;
//using Moq;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using NUnit;
//using NUnit.Framework;

//public class OfferServiceTests
//{
//    private Mock<IRepository> repositoryMock;
//    private OfferService offerService;

//    [SetUp]
//    public void Setup()
//    {
//        repositoryMock = new Mock<IRepository>();
//        offerService = new OfferService(repositoryMock.Object);
//    }

//    //[Test]
//    //public async Task AllBrandsAsync_ShouldReturnAllBrands()
//    //{
//    //    // Arrange
//    //    var brands = new List<Brand>
//    //    {
//    //        new Brand { Id = 1, Name = "Brand1" },
//    //        new Brand { Id = 2, Name = "Brand2" },
//    //    };

//    //    repositoryMock.Setup(r => r.AllReadOnly<Brand>())
//    //        .Returns(brands.AsQueryable());

//    //    // Act
//    //    var result = await offerService.AllBrandsAsync();

//    //    // Assert
//    //    Assert.That(result.Count(), Is.EqualTo(2));
//    //    Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
//    //    Assert.That(result.ElementAt(0).Name, Is.EqualTo("Brand1"));
//    //    Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
//    //    Assert.That(result.ElementAt(1).Name, Is.EqualTo("Brand2"));
//    //}

//    [Test]
//    public async Task AllBrandsAsync_ShouldReturnAllBrands()
//    {
//        // Arrange
//        var brands = new List<Brand>
//        {
//            new Brand { Id = 1, Name = "Brand1" },
//            new Brand { Id = 2, Name = "Brand2" }
//        };

//        repositoryMock.Setup(r => r.AllReadOnly<Brand>())
//            .Returns(new TestAsyncEnumerable<Brand>(brands));

//        // Act
//        var result = await offerService.AllBrandsAsync();

//        // Assert
//        Assert.That(result.Count(), Is.EqualTo(2));
//        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
//        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Brand1"));
//        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
//        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Brand2"));
//    }



//    [Test]
//    public async Task AllCarTypesAsync_ShouldReturnAllCarTypes()
//    {
//        // Arrange
//        var carTypes = new List<CarType>
//        {
//            new CarType { Id = 1, Name = "CarType1" },
//            new CarType { Id = 2, Name = "CarType2" },
//        };

//        repositoryMock.Setup(r => r.AllReadOnly<CarType>())
//            .Returns(carTypes.AsQueryable());
//    }

//    [Test]

//    public async Task AllCitiesAsync_ShouldReturnAllCities()
//    {
//        // Arrange
//        var cities = new List<City>
//        {
//            new City { Id = 1, Name = "City1" },
//            new City { Id = 2, Name = "City2" },
//        };

//        repositoryMock.Setup(r => r.AllReadOnly<City>())
//            .Returns(cities.AsQueryable());

//        // Act
//        var result = await offerService.AllCitiesAsync();

//        // Assert
//        Assert.That(result.Count(), Is.EqualTo(2));
//        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
//        Assert.That(result.ElementAt(0).Name, Is.EqualTo("City1"));
//        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
//        Assert.That(result.ElementAt(1).Name, Is.EqualTo("City2"));
//    }
//    [Test]

//    public async Task AllColorsAsync_ShouldReturnAllColors()
//    {
//        // Arrange
//        var colors = new List<Color>
//        {
//            new Color { Id = 1, Name = "Color1" },
//            new Color { Id = 2, Name = "Color2" },
//        };

//        repositoryMock.Setup(r => r.AllReadOnly<Color>())
//            .Returns(colors.AsQueryable());

//        // Act
//        var result = await offerService.AllColorsAsync();

//        // Assert
//        Assert.That(result.Count(), Is.EqualTo(2));
//        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
//        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Color1"));
//        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
//        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Color2"));
//    }
//    [Test]

//    public async Task AllFuelsAsync_ShouldReturnAllFuels()
//    {
//        // Arrange
//        var fuels = new List<Fuel>
//        {
//            new Fuel { Id = 1, Name = "Fuel1" },
//            new Fuel { Id = 2, Name = "Fuel2" },
//        };

//        repositoryMock.Setup(r => r.AllReadOnly<Fuel>())
//            .Returns(fuels.AsQueryable());

//        // Act
//        var result = await offerService.AllFuelsAsync();

//        // Assert
//        Assert.That(result.Count(), Is.EqualTo(2));
//        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
//        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Fuel1"));
//        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
//        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Fuel2"));
//    }

//    [Test]
//    public async Task AllTransmissionsAsync_ShouldReturnAllTransmissions()
//    {
//        // Arrange
//        var transmissions = new List<Transmission>
//        {
//            new Transmission { Id = 1, Name = "Transmission1" },
//            new Transmission { Id = 2, Name = "Transmission2" },
//        };

//        repositoryMock.Setup(r => r.AllReadOnly<Transmission>())
//            .Returns(transmissions.AsQueryable());

//        // Act
//        var result = await offerService.AllTransmissionsAsync();

//        // Assert
//        Assert.That(result.Count(), Is.EqualTo(2));
//        Assert.That(result.ElementAt(0).Id, Is.EqualTo(1));
//        Assert.That(result.ElementAt(0).Name, Is.EqualTo("Transmission1"));
//        Assert.That(result.ElementAt(1).Id, Is.EqualTo(2));
//        Assert.That(result.ElementAt(1).Name, Is.EqualTo("Transmission2"));
//    }
//}