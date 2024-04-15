using CarSale.Core.Models.Offer;
using CarSale.Data.Models;

namespace System.Linq
{
    public static class IQuerableOfferExtension
    {
        public static IQueryable<OfferServiceModel> ProjectToOfferServiceModel(this IQueryable<Offer> offers)
        {
            return offers
                .Select(o => new OfferServiceModel()
                {
                    Id = o.Id,
                    ImageUrl = o.ImageUrl,
                    Price = o.Price,
                    Title = o.Brand.Name + " " + o.CarModel,
                    CarModel = o.CarModel,
                    Description = o.Description
                });
        }
    }
}
