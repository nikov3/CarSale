using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.CarType;

namespace CarSale.Data.Models
{
    public class CarType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<Offer> Offers { get; set; } = new List<Offer>();
    }
}
