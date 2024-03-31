using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.Transmission;

namespace CarSale.Data.Models
{
    public class Transmission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    }
}
