using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSale.Data.Entities
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int CarBrandId { get; set; }

        [Required]
        [ForeignKey(nameof(CarBrandId))]
        public CarBrand CarBrand { get; set; } = null!;
    }
}
