using CarSale.Core.Contracts;
using CarSale.Core.Models.Home;
using CarSale.Core.Models.Offer;
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

        public async Task<IEnumerable<OfferBrandServiceModel>> AllBrandsAsync()
        {
            return await repository.AllReadOnly<Brand>()
                .Select(b => new OfferBrandServiceModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<OfferCarModelServiceModel>> AllCarModelsAsync()
        {
            return await repository.AllReadOnly<CarModel>()
                .Select(cm =>  new OfferCarModelServiceModel()
                {
                    Id = cm.Id,
                    Name = cm.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<OfferCarTypeServiceModel>> AllCarTypesAsync()
        {
            return await repository.AllReadOnly<CarType>()
                .Select(ct => new OfferCarTypeServiceModel()
                {
                    Id = ct.Id,
                    Name = ct.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<OfferCityServiceModel>> AllCitiesAsync()
        {
            return await repository.AllReadOnly<City>()
                .Select(c => new OfferCityServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<OfferColorServiceModel>> AllColorsAsync()
        {
            return await repository.AllReadOnly<Color>()
                .Select(c => new OfferColorServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<OfferFuelServiceModel>> AllFuelsAsync()
        {
            return await repository.AllReadOnly<Fuel>()
                .Select(f => new OfferFuelServiceModel()
                {
                    Id = f.Id,
                    Name = f.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<OfferTransmissionServiceModel>> AllTransmissionsAsync()
        {
            return await repository.AllReadOnly<Transmission>()
                .Select(t => new OfferTransmissionServiceModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                .ToListAsync();
        }

        public async Task<bool> BrandExistsAsync(int brandId)
        {
            return await repository.AllReadOnly<Brand>()
                .AnyAsync(b => b.Id == brandId);
        }

        public async Task<bool> CarModelExistsAsync(int carModelId)
        {
            return await repository.AllReadOnly<CarModel>()
                .AnyAsync(cm => cm.Id == carModelId);
        }

        public async Task<bool> CarTypeExistsAsync(int carTypeId)
        {
            return await repository.AllReadOnly<CarType>()
                .AnyAsync(ct => ct.Id == carTypeId);
        }

        public async Task<bool> CityExistsAsync(int cityId)
        {
            return await repository.AllReadOnly<City>()
                .AnyAsync(c => c.Id == cityId);
        }

        public async Task<bool> ColorsExistsAsync(int colorsId)
        {
            return await repository.AllReadOnly<Color>()
                .AnyAsync(c => c.Id == colorsId);
        }

        public async Task<int> CreateAsync(OfferFormModel model, int dealerId)
        {
            Offer offer = new Offer()
            {
                BrandId = model.BrandId,
                CarModelId = model.CarModelId,
                CarTypeId = model.CarTypeId,
                ColorId = model.ColorId,
                FuelId = model.FuelId,
                TransmissionId = model.TransmissionId,
                CityId = model.CityId,
                HorsePower = model.HorsePower,
                Year = model.Year,
                Desription = model.Description,
                ImageUrl = model.ImageUrl,
                DealerId = dealerId,
                Milage = model.Milage,
                Price = model.Price,
                CreatedOn = DateTime.Now,
            };

            await repository.AddAsync(offer);
            await repository.SaveChangesAsync();

            return offer.Id;
        }

        public async Task<bool> FuelExistsAsync(int fuelId)
        {
            return await repository.AllReadOnly<Fuel>()
                .AnyAsync(f => f.Id == fuelId);
        }

        public async Task<IEnumerable<OfferIndexServiceModel>> LastThreeOffersAsync()
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

        public async Task<bool> TransmissionExistsAsync(int transmissionId)
        {
            return await repository.AllReadOnly<Transmission>()
                .AnyAsync(t => t.Id == transmissionId);
        }
    }
}
