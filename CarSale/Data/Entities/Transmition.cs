using System.ComponentModel.DataAnnotations;

namespace CarSale.Data.Entities
{
    public class Transmition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string TransmitionType { get; set; } = string.Empty;

        public ICollection<CarOffer> CarOffers { get; set; } = new List<CarOffer>();
    }
}
