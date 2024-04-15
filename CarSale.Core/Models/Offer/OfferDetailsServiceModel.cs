using CarSale.Core.Contracts;
using CarSale.Core.Models.Dealer;
using System.ComponentModel.DataAnnotations;

namespace CarSale.Core.Models.Offer
{
    public class OfferDetailsServiceModel : IOfferModel
    {
        public int Id { get; set; }

        public string Brand { get; set; } = null!;

        public string CarModel { get; set; } = null!;

        public DealerServiceModel Dealer { get; set; } = null!;

        public int HorsePower { get; set; }

        public string Fuel { get; set; } = null!;

        public string Transmission { get; set; } = null!;

        public string CarType { get; set; } = null!;

        public string Color { get; set; } = null!;

        public string City { get; set; } = null!;

        public decimal Price { get; set; }

        public int Year { get; set; }

        public int Milage { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;


        //public int Id { get; set; }

        //public string Title { get; set; } = string.Empty;

        //[Display(Name = "Image URL")]
        //public string ImageUrl { get; set; } = string.Empty;

        //public decimal Price { get; set; }

        //public string Description { get; set; } = null!;

        //public string Fuel { get; set; } = null!;

        //public string Transmission { get; set; } = null!;

        //public string CarType { get; set; } = null!;

        //public string Color { get; set; } = null!;

        //public string City { get; set; } = null!;

        //public int HorsePower { get; set; }

        //public int Millage { get; set; }

        //public int Year { get; set; }

        //public string CreatedOn { get; set; } = null!;

        //public DealerServiceModel Dealer { get; set; } = null!;
    }
}
