using CarSale.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace CarSale.Core.Models.Offer
{
    public class AllOffersQueryModel
    {
        public int OffersPerPage { get; } = 3;

        public string Brand { get; set; } = null!;

        [Display(Name = "Model")]
        public string CarModel { get; set; } = null!;
        
        public string Fuel { get; set; } = null!;
        
        public string Transmission { get; set; } = null!;

        [Display(Name = "Type")]
        public string CarType { get; set; } = null!;

        public string Color { get; set; } = null!;

        public string City { get; set; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = null!;

        public OfferSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalOffersCount { get; set; }

        public IEnumerable<string> Brands { get; set; }

        public IEnumerable<string> Fuels { get; set; }

        public IEnumerable<string> Transmissions { get; set; }

        public IEnumerable<string> CarTypes { get; set; }

        public IEnumerable<string> Colors { get; set; }

        public IEnumerable<string> Cities { get; set; }

        public IEnumerable<OfferServiceModel> Offers { get; set; } = new List<OfferServiceModel>();
    }
}
