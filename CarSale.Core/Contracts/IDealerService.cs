using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Core.Contracts
{
    public interface IDealerService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber);

        Task CreateAsync(string userId, string phoneNumber);

        Task<int?> GetDealerIdAsync(string userId);
    }
}
