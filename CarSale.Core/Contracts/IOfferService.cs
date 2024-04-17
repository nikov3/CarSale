using CarSale.Core.Enumerations;
using CarSale.Core.Models.Home;
using CarSale.Core.Models.Offer;

namespace CarSale.Core.Contracts
{
    public interface IOfferService
    {
        Task<IEnumerable<OfferIndexServiceModel>> LastThreeOffersAsync();

        Task<IEnumerable<OfferBrandServiceModel>> AllBrandsAsync();
        
        Task<IEnumerable<OfferFuelServiceModel>> AllFuelsAsync();
        
        Task<IEnumerable<OfferTransmissionServiceModel>> AllTransmissionsAsync();
        
        Task<IEnumerable<OfferCarTypeServiceModel>> AllCarTypesAsync();
        
        Task<IEnumerable<OfferColorServiceModel>> AllColorsAsync();
        
        Task<IEnumerable<OfferCityServiceModel>> AllCitiesAsync();

        Task<bool> BrandExistsAsync(int brandId);
        
        Task<bool> FuelExistsAsync(int fuelId);
        
        Task<bool> TransmissionExistsAsync(int transmissionId);
        
        Task<bool> CarTypeExistsAsync(int carTypeId);
        
        Task<bool> ColorsExistsAsync(int colorsId);
        
        Task<bool> CityExistsAsync(int cityId);
        
        Task<int> CreateAsync(OfferFormModel model, int dealerId);

        Task<OfferQueryServiceModel> AllAsync(
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
            int offersPerPage = 1);

        Task<IEnumerable<string>> AllBrandsNamesAsync();

        Task<IEnumerable<string>> AllFuelsNamesAsync();

        Task<IEnumerable<string>> AllTransmissionsNamesAsync();

        Task<IEnumerable<string>> AllCarTypesNamesAsync();
        
        Task<IEnumerable<string>> AllColorsNamesAsync();
        
        Task<IEnumerable<string>> AllCitiesNamesAsync();

        Task<IEnumerable<OfferServiceModel>> AllOffersByDealerIdAsync(int dealerId);

        Task<bool> ExistsAsync(int id);

        Task<OfferDetailsServiceModel> OfferDetailsByIdAsync(int id);

        Task EditAsync(int offerId, OfferFormModel model);

        Task<bool> HasDealerWithIdAsync(int offerId, string userId);

        Task<OfferFormModel?> GetOfferFormModelByIdAsync(int id);

        Task DeleteAsync(int offerId);

        Task<IEnumerable<OfferServiceModel>> GetUnApprovedAsync();

        Task ApproveOfferAsync(int offerId);
    }
}
