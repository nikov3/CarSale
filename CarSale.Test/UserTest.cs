using CarSale.Core.Services;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;
using Moq;

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
            var userId = "1";
            var user = new ApplicationUser
            {
                Id = userId,
                FirstName = "John",
                LastName = "Doe"
            };

            _repositoryMock.Setup(r => r.GetByIdAsync<ApplicationUser>(userId))
                .ReturnsAsync(user);

            var result = await _userService.UserFullNameAsync(userId);

            Assert.That(result, Is.EqualTo($"{user.FirstName} {user.LastName}"));
        }

        [Test]
        public async Task UserFullNameAsync_WithInvalidUserId_ShouldReturnEmptyString()
        {
            var userId = "1";
            ApplicationUser user = null;

            _repositoryMock.Setup(r => r.GetByIdAsync<ApplicationUser>(userId))
                .ReturnsAsync(user);

            var result = await _userService.UserFullNameAsync(userId);

            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public async Task AllAsync_WithUsers_ShouldReturnAllUsers()
        {
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

            var result = await _userService.AllAsync();

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
            var users = new List<ApplicationUser>();

            _repositoryMock.Setup(r => r.AllReadOnly<ApplicationUser>())
                .Returns(new TestAsyncEnumerable<ApplicationUser>(users).AsQueryable());

            var result = await _userService.AllAsync();

            Assert.That(result.Count(), Is.EqualTo(users.Count));
        }
    }
}