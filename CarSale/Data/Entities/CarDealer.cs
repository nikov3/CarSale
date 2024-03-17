using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarSale.Data.Entities
{
    public class CarDealer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Company name must be between {2} and {1} length")]
        public string Name { get; set; } = null!;

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Contact email must be between {2} and {1} length")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Contact email is not valid")]
        public string ContactEmail { get; set; } = null!;

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Contact phone must be between {2} and {1} length")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Contact phone is not valid")]
        public string? ContactPhone { get; set; }

        //could be a picture
        //[StringLength(LogoUrlMaxLength, MinimumLength = LogoUrlMinLength, ErrorMessage = "Logo url must be between {2} and {1} length")]
        //public string LogoUrl { get; set; } = null!;

        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<CarOffer> CarOffers { get; set; } = new HashSet<CarOffer>();
        //public bool IsDeleted { get; set; } = false;
    }
}
