using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.Color;

namespace CarSale.Data.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    }
}
