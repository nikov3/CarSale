using System.ComponentModel.DataAnnotations;
using static CarSale.Core.Constants.MessageConstants;
using static CarSale.Infrastructure.Constants.DataConstants.Dealer;

namespace CarSale.Core.Models.Dealer
{
    public class BecomeDealerFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PhoneMaxLength, 
            MinimumLength = PhoneMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}
