using System.ComponentModel.DataAnnotations;

namespace CarSale.Data.Entities
{
    public class CarType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string TypeName { get; set; } = null!;
        public ICollection<CarOffer> CarOffers { get; set; } = new List<CarOffer>();
    }
}
