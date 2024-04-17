using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.Dealer;

namespace CarSale.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Company name must be between {2} and {1} length")]
        [Required]
        [MaxLength(NameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Company name must be between {2} and {1} length")]
        [Required]
        [MaxLength(NameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

        public Dealer? Dealer { get; set; }
    }
}
