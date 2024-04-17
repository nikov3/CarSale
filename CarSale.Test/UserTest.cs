using CarSale.Core.Contracts;
using CarSale.Core.Models.Admin.User;
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
    internal class UserTest
    {
        private UserService _userService;
        private DealerService _dealerService;
        private Mock<IRepository> _repositoryMock;

        [SetUp]
        public void Setup()
        {
            _repositoryMock = new Mock<IRepository>();
            _userService = new UserService(_repositoryMock.Object);
            _dealerService = new DealerService(_repositoryMock.Object);
        }

        [Test]
        public async Task UserFullNameAsync_WithValidUserId_ShouldReturnFullName()
        {
            // Arrange
            var userId = "1";
            var user = new ApplicationUser
            {
                Id = userId,
                FirstName = "John",
                LastName = "Doe"
            };

            _repositoryMock.Setup(r => r.GetByIdAsync<ApplicationUser>(userId))
                .ReturnsAsync(user);

            // Act
            var result = await _userService.UserFullNameAsync(userId);

            // Assert
            Assert.That(result, Is.EqualTo($"{user.FirstName} {user.LastName}"));
        }

        [Test]
        public async Task UserFullNameAsync_WithInvalidUserId_ShouldReturnEmptyString()
        {
            // Arrange
            var userId = "1";
            ApplicationUser user = null;

            _repositoryMock.Setup(r => r.GetByIdAsync<ApplicationUser>(userId))
                .ReturnsAsync(user);

            // Act
            var result = await _userService.UserFullNameAsync(userId);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public async Task AllAsync_WithUsers_ShouldReturnAllUsers()
        {
            // Arrange
            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Email = "test@gmail.com",
                    FirstName = "John",
                    LastName = "Doe",
                    Dealer = new Dealer
                    {
                        PhoneNumber = "123456789"
                    }
                },
                new ApplicationUser
                {
                    Email = "test2@abv.bg",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Dealer = null
                }
            };

            _repositoryMock.Setup(r => r.AllReadOnly<ApplicationUser>())
                .Returns(new TestAsyncEnumerable<ApplicationUser>(users).AsQueryable());

            // Act

            var result = await _userService.AllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(users.Count));
            Assert.That(result.First().Email, Is.EqualTo(users.First().Email));
            Assert.That(result.First().FullName, Is.EqualTo($"{users.First().FirstName} {users.First().LastName}"));
            Assert.Multiple(() =>
            {
                Assert.That(result.First().PhoneNumber, Is.EqualTo(users.First().Dealer.PhoneNumber));
                Assert.That(result.First().IsDealer, Is.True);

                Assert.That(result.Last().Email, Is.EqualTo(users.Last().Email));
                Assert.That(result.Last().FullName, Is.EqualTo($"{users.Last().FirstName} {users.Last().LastName}"));
                Assert.That(result.Last().PhoneNumber, Is.Null);
            });
        }

        [Test]
        public async Task AllAsync_WithoutUsers_ShouldReturnEmptyCollection()
        {
            // Arrange
            var users = new List<ApplicationUser>();

            _repositoryMock.Setup(r => r.AllReadOnly<ApplicationUser>())
                .Returns(new TestAsyncEnumerable<ApplicationUser>(users).AsQueryable());

            // Act
            var result = await _userService.AllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(users.Count));
        }
    }
}