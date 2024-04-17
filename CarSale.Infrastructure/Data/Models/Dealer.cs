using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CarSale.Infrastructure.Constants.DataConstants.Dealer;

namespace CarSale.Data.Models
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class Dealer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(PhoneMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Offer> Offers { get; set; } = new HashSet<Offer>();
    }
}
