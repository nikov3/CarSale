using CarSale.Core.Contracts;
using System.ComponentModel.DataAnnotations;
using static CarSale.Core.Constants.MessageConstants;
using static CarSale.Infrastructure.Constants.DataConstants.Offer;

namespace CarSale.Core.Models.Offer
{
    public class OfferServiceModel : IOfferModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLength,
            MinimumLength = TitleMinLength,
            ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Display(Name ="Image URL")]
        [Required(ErrorMessage = RequiredMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),
            PriceMinimum,
            PriceMaximum,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Price must be a positive number and less than {2} leva")]
        public decimal Price {  get; set; }

        [StringLength(CarModelMaxLength,
            MinimumLength = CarModelMinLength,
            ErrorMessage = LengthMessage)]
        public string CarModel { get; set; } = string.Empty;

        [StringLength(DescriptionMaxLength,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;
    }
}