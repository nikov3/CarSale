using CarSale.Core.Contracts;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Core.Services
{
    public class DealerService : IDealerService
    {
        private readonly IRepository repository;

        public DealerService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task CreateAsync(string userId, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.UserId == userId);
        }

        public Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
