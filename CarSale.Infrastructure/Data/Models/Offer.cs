using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CarSale.Data.Models
{
    public class Offer
    {
		[Key]
		public Guid Id { get; set; } = Guid.NewGuid();

		public int DealerId { get; set; }

		[ForeignKey(nameof(DealerId))]
		public Dealer Dealer { get; set; } = null!;

		[Required]
        public int BrandId { get; set; }

        [Required]
        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; } = null!;

        [Required]
        public int CarModelId { get; set; }

        [Required]
        [ForeignKey(nameof(CarModelId))]
        public CarModel CarModel { get; set; } = null!;

        [Required]
        public int FuelId { get; set; }

        [Required]
        [ForeignKey(nameof(FuelId))]
        public Fuel Fuel { get; set; } = null!;

        [Required]
        public int TransmissionId { get; set; }

        [Required]
        [ForeignKey(nameof(TransmissionId))]
        public Transmission Transmission { get; set; } = null!;

        [Required]
        public int CarTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(CarTypeId))]
        public CarType CarType { get; set; } = null!;

        [Required]
        public int ColorId { get; set; }

        [Required]
        [ForeignKey(nameof(ColorId))]
        public Color Color { get; set; } = null!;

        [Required]
        public int CityId { get; set; }

        [Required]
        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public int Price { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,0)")]
        public int Year { get; set; }        

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public int Milage { get; set; }

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
