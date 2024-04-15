using CarSale.Core.Contracts;
using System.Text.RegularExpressions;

namespace CarSale.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this IOfferModel offer)
        {
            string info = offer.CarModel.Replace(" ", "-") + GetDescription(offer.Description);
            info = Regex.Replace(info, @"[^a-zA-Z0-9\-]", string.Empty);

            return info;
        }

        private static string GetDescription(string description)
        {
            description = string.Join("-", description.Split(" ").Take(3));

            return description;
        }
    }
}