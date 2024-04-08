using CarSale.Core.Models.Home;
using CarSale.Core.Models.Offer;

namespace CarSale.Core.Contracts
{
    public interface IOfferService
    {
        Task<IEnumerable<OfferIndexServiceModel>> LastThreeOffersAsync();

        Task<IEnumerable<OfferBrandServiceModel>> AllBrandsAsync();

        Task<IEnumerable<OfferCarModelServiceModel>> AllCarModelsAsync();
        
        Task<IEnumerable<OfferFuelServiceModel>> AllFuelsAsync();
        
        Task<IEnumerable<OfferTransmissionServiceModel>> AllTransmissionsAsync();
        
        Task<IEnumerable<OfferCarTypeServiceModel>> AllCarTypesAsync();
        
        Task<IEnumerable<OfferColorServiceModel>> AllColorsAsync();
        
        Task<IEnumerable<OfferCityServiceModel>> AllCitiesAsync();

        Task<bool> BrandExistsAsync(int brandId);
        
        Task<bool> CarModelExistsAsync(int carModelId);
        
        Task<bool> FuelExistsAsync(int fuelId);
        
        Task<bool> TransmissionExistsAsync(int transmissionId);
        
        Task<bool> CarTypeExistsAsync(int carTypeId);
        
        Task<bool> ColorsExistsAsync(int colorsId);
        
        Task<bool> CityExistsAsync(int cityId);
        
        Task<int> CreateAsync(OfferFormModel model, int dealerId);
    }
}
