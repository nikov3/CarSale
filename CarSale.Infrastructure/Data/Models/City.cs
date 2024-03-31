using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.City;

namespace CarSale.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty; 

        public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    }
}
