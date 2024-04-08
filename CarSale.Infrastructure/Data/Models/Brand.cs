using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.Brand;

namespace CarSale.Data.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public List<Offer> Offers { get; set; } = new List<Offer>();

        public ICollection<CarModel> CarModels { get; set; } = new List<CarModel>();
    }
}
