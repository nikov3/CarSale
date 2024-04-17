using System.ComponentModel.DataAnnotations;

namespace CarSale.Core.Models.Dealer
{
    public class DealerServiceModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
