namespace CarSale.Core.Models.Offer
{
    public class OfferQueryServiceModel
    {
        public int TotalOffersCount { get; set; }

        public IEnumerable<OfferServiceModel> Offers { get; set; } = new List<OfferServiceModel>();
    }
}
