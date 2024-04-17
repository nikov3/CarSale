using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static CarSale.Infrastructure.Constants.DataConstants.Dealer;

namespace CarSale.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(NameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(NameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

        public Dealer? Dealer { get; set; }
    }
}
