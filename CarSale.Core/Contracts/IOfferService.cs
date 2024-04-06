using CarSale.Core.Models.Home;

namespace CarSale.Core.Contracts
{
    public interface IOfferService
    {
        Task<IEnumerable<OfferIndexServiceModel>> LastThreeOffers();
    }
}
