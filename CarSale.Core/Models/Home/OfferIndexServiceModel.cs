using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Core.Models.Home
{
    public class OfferIndexServiceModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
