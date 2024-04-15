using CarSale.Core.Contracts;
using System.ComponentModel.DataAnnotations;
using static CarSale.Core.Constants.MessageConstants;
using static CarSale.Infrastructure.Constants.DataConstants.Offer;

namespace CarSale.Core.Models.Offer
{
    public class OfferFormModel : IOfferModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        public IEnumerable<OfferBrandServiceModel> Brands { get; set; } =
            new List<OfferBrandServiceModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Model")]
        [StringLength(CarModelMaxLength,
            MinimumLength = CarModelMinLength,
            ErrorMessage = LengthMessage)]
        public string CarModel { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(int),
            HorsePowerMinimum,
            HorsePowerMaximum,
            ErrorMessage = "HP must be between {1} and {2}")]
        public int HorsePower { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Fuel")]
        public int FuelId { get; set; }

        public IEnumerable<OfferFuelServiceModel> Fuels { get; set; } =
            new List<OfferFuelServiceModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Transmission")]
        public int TransmissionId { get; set; }

        public IEnumerable<OfferTransmissionServiceModel> Transmissions { get; set; } =
            new List<OfferTransmissionServiceModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Type")]
        public int CarTypeId { get; set; }

        public IEnumerable<OfferCarTypeServiceModel> CarTypes { get; set; } =
            new List<OfferCarTypeServiceModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Color")]
        public int ColorId { get; set; }

        public IEnumerable<OfferColorServiceModel> Colors { get; set; } =
            new List<OfferColorServiceModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "City")]
        public int CityId { get; set; }

        public IEnumerable<OfferCityServiceModel> Cities { get; set; } =
            new List<OfferCityServiceModel>();

        [Required]
        [Range(typeof(int),
            YearMinimum,
            YearMaximum,
            ErrorMessage = "Year must be between {1} and {2}")]
        public int Year { get; set; }

        [Required]
        [Range(typeof(int),
            MilageMinimum,
            MilageMaximum,
            ErrorMessage = "Milage must be a positive number and less than {2} km")]
        public int Milage { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(DescriptionMaxLength,
            MinimumLength = DescriptionMinLength, 
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),
            PriceMinimum,
            PriceMaximum,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Price must be a positive number and less than {2} leva")]
        public decimal Price { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
