using CarSale.Core.Contracts;
using CarSale.Core.Enumerations;
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

        public async Task<OfferQueryServiceModel> AllAsync(
            string? brand = null, 
            string? carModel = null, 
            string? fuel = null, 
            string? transmission = null, 
            string? carType = null, 
            string? color = null, 
            string? city = null, 
            string? searchTerm = null, 
            OfferSorting sorting = OfferSorting.Newest, 
            int currentPage = 1, 
            int offersPerPage = 1)
        {
            var offersToShow = repository.AllReadOnly<Offer>();

            if (brand != null)
            {
                offersToShow = offersToShow
                    .Where(o => o.Brand.Name == brand);
            }

            if (fuel != null)
            {
                offersToShow = offersToShow
                    .Where(o => o.Fuel.Name == fuel);
            }

            if (transmission != null)
            {
                offersToShow = offersToShow
                    .Where(o => o.Transmission.Name == transmission);
            }

            if (carType != null)
            {
                offersToShow = offersToShow
                    .Where(o => o.CarType.Name == carType);
            }

            if (color != null)
            {
                offersToShow = offersToShow
                    .Where(o => o.Color.Name == color);
            }

            if (city != null)
            {
                offersToShow = offersToShow
                    .Where(o => o.City.Name == city);
            }

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                offersToShow = offersToShow
                    .Where(o => (o.CarModel.ToLower().Contains(normalizedSearchTerm) ||
                                o.Description.ToLower().Contains(normalizedSearchTerm)));
            }

            offersToShow = sorting switch
            {
                OfferSorting.Price => offersToShow
                    .OrderBy(o => o.Price),
                OfferSorting.CarYear => offersToShow
                    .OrderByDescending(o => o.Year)
                    .ThenBy(o => o.Price)
                    .ThenByDescending (o => o.Id),
                _ => offersToShow
                    .OrderByDescending(o => o.Id)
            };

            var offes = await offersToShow
                .Skip((currentPage - 1) * offersPerPage)
                .Take(offersPerPage)
                .ProjectToOfferServiceModel()
                .ToListAsync();

            int totalOffers = await offersToShow.CountAsync();

            return new OfferQueryServiceModel()
            {
                TotalOffersCount = totalOffers,
                Offers = offes
            };
        }

        public async Task<IEnumerable<string>> AllBrandsNamesAsync()
        {
            return await repository.AllReadOnly<Brand>()
                .Select(b => b.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllFuelsNamesAsync()
        {
            return await repository.AllReadOnly<Fuel>()
                .Select(f => f.Name)
                .Distinct()
                .ToListAsync();
        }
        
        public async Task<IEnumerable<string>> AllTransmissionsNamesAsync()
        {
            return await repository.AllReadOnly<Transmission>()
                .Select(t => t.Name)
                .Distinct()
                .ToListAsync();
        }
        
        public async Task<IEnumerable<string>> AllCarTypesNamesAsync()
        {
            return await repository.AllReadOnly<CarType>()
                .Select(ct => ct.Name)
                .Distinct()
                .ToListAsync();
        }
        
        public async Task<IEnumerable<string>> AllColorsNamesAsync()
        {
            return await repository.AllReadOnly<Color>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }
        
        public async Task<IEnumerable<string>> AllCitiesNamesAsync()
        {
            return await repository.AllReadOnly<City>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
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
                CarModel = model.CarModel,
                CarTypeId = model.CarTypeId,
                ColorId = model.ColorId,
                FuelId = model.FuelId,
                TransmissionId = model.TransmissionId,
                CityId = model.CityId,
                HorsePower = model.HorsePower,
                Year = model.Year,
                Description = model.Description,
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
                    CarModel = o.CarModel,
                    Description = o.Description,
                    Title = (o.Brand.Name + " " + o.CarModel),
                    ImageUrl = o.ImageUrl
                }).ToListAsync();
        }

        public async Task<bool> TransmissionExistsAsync(int transmissionId)
        {
            return await repository.AllReadOnly<Transmission>()
                .AnyAsync(t => t.Id == transmissionId);
        }

        public async Task<IEnumerable<OfferServiceModel>> AllOffersByDealerIdAsync(int dealerId)
        {
            return await repository .AllReadOnly<Offer>()
                .Where(o => o.DealerId == dealerId)
                .ProjectToOfferServiceModel()
                .ToListAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnly<Offer>()
                .AnyAsync(o => o.Id == id);
        }

        public async Task<OfferDetailsServiceModel> OfferDetailsByIdAsync(int id)
        {
            var offer = await repository.AllReadOnly<Offer>()
                .Where(o => o.Id == id).FirstAsync();

            return await repository.AllReadOnly<Offer>()
                .Where(o => o.Id == id)
                .Select(o => new OfferDetailsServiceModel()
                {
                    Id = o.Id,
                    Brand = o.Brand.Name,
                    CarModel = o.CarModel,
                    Title = o.Brand.Name + " " + o.CarModel,
                    Dealer = new Models.Dealer.DealerServiceModel()
                    {
                        FullName = $"{o.Dealer.User.FirstName} {o.Dealer.User.LastName}",
                        PhoneNumber = o.Dealer.PhoneNumber
                    },
                    HorsePower = o.HorsePower,
                    Fuel = o.Fuel.Name,
                    Transmission = o.Transmission.Name,
                    CarType = o.CarType.Name,
                    Color = o.Color.Name,
                    City = o.City.Name,
                    Price = o.Price,
                    Year = o.Year,
                    Milage = o.Milage,
                    ImageUrl = o.ImageUrl,
                    Description = o.Description,
                    CreatedOn = $"{o.CreatedOn.Hour}:{o.CreatedOn.Minute} {o.CreatedOn.Date.ToString()}"
                })
                .FirstAsync();
        }

        public async Task EditAsync(int offerId, OfferFormModel model)
        {
            var offer = await repository.GetByIdAsync<Offer>(offerId);

            if(offer != null)
            {
                offer.BrandId = model.BrandId;
                offer.CarModel = model.CarModel;
                offer.FuelId = model.FuelId;
                offer.TransmissionId = model.TransmissionId;
                offer.CarTypeId = model.CarTypeId;
                offer.ColorId = model.ColorId;
                offer.CityId = model.CityId;
                offer.Description = model.Description;
                offer.Price = model.Price;
                offer.Year = model.Year;
                offer.Milage = model.Milage;
                offer.ImageUrl = model.ImageUrl;
                offer.HorsePower = model.HorsePower;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> HasDealerWithIdAsync(int offerId, string userId)
        {
            return await repository.AllReadOnly<Offer>()
                .AnyAsync(o => o.Id == offerId && o.Dealer.UserId == userId);
        }

        public async Task<OfferFormModel?> GetOfferFormModelByIdAsync(int id)
        {
            var offer = await repository.AllReadOnly<Offer>()
                .Where(o => o.Id == id)
                .Select(o => new OfferFormModel()
                {
                    BrandId = o.BrandId,
                    CarModel = o.CarModel,
                    Title = o.Brand.Name + " " + o.CarModel,
                    FuelId = o.FuelId,
                    TransmissionId = o.TransmissionId,
                    CarTypeId = o.CarTypeId,
                    ColorId = o.ColorId,
                    CityId = o.CityId,
                    HorsePower = o.HorsePower,
                    Year = o.Year,
                    Milage = o.Milage,
                    Description = o.Description,
                    ImageUrl = o.ImageUrl,
                    Price = o.Price
                })
                .FirstOrDefaultAsync();

            if(offer != null)
            {
                offer.Brands = await AllBrandsAsync();
                offer.Fuels = await AllFuelsAsync();
                offer.Transmissions = await AllTransmissionsAsync();
                offer.CarTypes = await AllCarTypesAsync();
                offer.Colors = await AllColorsAsync();
                offer.Cities = await AllCitiesAsync();
            }

            return offer;
        }

        public async Task DeleteAsync(int offerId)
        {
            await repository.DeleteAsync<Offer>(offerId);

            await repository.SaveChangesAsync();
        }
    }
}
