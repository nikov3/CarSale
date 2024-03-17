using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CarSale.Data.Constants.CarOfferConstants;

namespace CarSale.Data.Entities
{
    public class CarOffer
    {
		[Key]
		public Guid Id { get; set; } = Guid.NewGuid();

		public int CarDealerId { get; set; }

		[ForeignKey(nameof(CarDealerId))]
		public CarDealer CarDealer { get; set; } = null!;

		[Required]
        public int CarBrandId { get; set; }

        [Required]
        [ForeignKey(nameof(CarBrandId))]
        public CarBrand CarBrand { get; set; } = null!;

        [Required]
        public int FuelId { get; set; }

        [Required]
        [ForeignKey(nameof(FuelId))]
        public Fuel Fuel { get; set; } = null!;

        [Required]
        public int TransmitionId { get; set; }

        [Required]
        [ForeignKey(nameof(TransmitionId))]
        public Transmition Transmition { get; set; } = null!;

        [Required]
        public int CarTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(CarTypeId))]
        public CarType CarType { get; set; } = null!;

        [Required]
        public int ColorId { get; set; }

        [Required]
        [ForeignKey(nameof(ColorId))]
        public CarColor Color { get; set; } = null!;

        [Required]
        public int CityId { get; set; }

        [Required]
        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        [Required]
        [MaxLength(MaxPriceLength)]
        public int Price { get; set; }

        [Required]
        [MaxLength(4)]
        [Range(1950, 2024)]
        public int Year { get; set; }        

        [Required]
        [MaxLength(MaxMilageLength)]
        public int Milage { get; set; }


    }
}
