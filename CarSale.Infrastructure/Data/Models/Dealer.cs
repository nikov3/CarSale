using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.Dealer;

namespace CarSale.Data.Models
{
    public class Dealer
    {
        [Key]
        public int Id { get; set; }

        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Company name must be between {2} and {1} length")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        //[StringLength(20, MinimumLength = 5, ErrorMessage = "Contact email must be between {2} and {1} length")]
        [MaxLength(EmailMaxLength)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Contact email is not valid")]
        public string ContactEmail { get; set; } = null!;

        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Contact phone must be between {2} and {1} length")]
        [MaxLength(PhoneMaxLength)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Contact phone is not valid")]
        public string? ContactPhone { get; set; }

        //could be a picture
        //[StringLength(LogoUrlMaxLength, MinimumLength = LogoUrlMinLength, ErrorMessage = "Logo url must be between {2} and {1} length")]
        //public string LogoUrl { get; set; } = null!;

        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Offer> Offers { get; set; } = new HashSet<Offer>();
        //public bool IsDeleted { get; set; } = false;
    }
}
