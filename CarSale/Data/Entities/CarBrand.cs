using System.ComponentModel.DataAnnotations;

namespace CarSale.Data.Entities
{
    public class CarBrand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; } = null!;

        public ICollection<CarOffer> CarOffers { get; set; } = new List<CarOffer>();

        // Navigation property
        //public ICollection<CarModel> CarModels { get; set; }
    }
}
