using CarSale.Core.Contracts;
using CarSale.Core.Models.Satistics;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CarSale.Core.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly IRepository repository;

        public StatisticService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<StatisticServiceModel> TotalAsync()
        {
            int totalOffers = await repository.AllReadOnly<Offer>()
				.Where(o => o.IsApproved)
				.CountAsync();
            int totalDealers = await repository.AllReadOnly<Dealer>() 
                .CountAsync();

            return new StatisticServiceModel 
            { 
                TotalOffers = totalOffers,
                TotalDealers = totalDealers
            };
        }
    }
}
