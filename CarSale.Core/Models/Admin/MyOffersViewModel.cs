using CarSale.Core.Models.Offer;

namespace CarSale.Core.Models.Admin
{
    public class MyOffersViewModel
    {
        public IEnumerable<OfferServiceModel> AddedOffers { get; set; } = new List<OfferServiceModel>();
    }
}
