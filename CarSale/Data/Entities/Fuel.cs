using System.ComponentModel.DataAnnotations;

namespace CarSale.Data.Entities
{
    public class Fuel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string FuelType { get; set; } = string.Empty;

        public ICollection<CarOffer> CarOffers { get; set; } = new List<CarOffer>();
    }
}
