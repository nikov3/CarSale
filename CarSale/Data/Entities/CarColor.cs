using System.ComponentModel.DataAnnotations;

namespace CarSale.Data.Entities
{
    public class CarColor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string ColorName { get; set; } = string.Empty;

        public ICollection<CarOffer> CarOffers { get; set; } = new List<CarOffer>();
    }
}
