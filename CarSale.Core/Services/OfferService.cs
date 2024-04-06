using CarSale.Core.Contracts;
using CarSale.Core.Models.Home;
using CarSale.Data.Models;
using CarSale.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CarSale.Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IRepository repository;

        public OfferService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<OfferIndexServiceModel>> LastThreeOffers()
        {
            return await repository
                .AllReadOnly<Offer>()
                .OrderByDescending(o => o.Id)
                .Take(3)
                .Select(o => new OfferIndexServiceModel() 
                {
                    Id = o.Id,
                    Title = (o.Brand.Name + " " + o.CarModel.Name),
                    ImageUrl = o.ImageUrl
                }).ToListAsync();
        }
    }
}
