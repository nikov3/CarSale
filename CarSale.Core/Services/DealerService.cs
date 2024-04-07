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

        public async Task CreateAsync(string userId, string phoneNumber)
        {
            await repository.AddAsync(new Dealer()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.UserId == userId);
        }

        public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.PhoneNumber == phoneNumber);
        }
    }
}
