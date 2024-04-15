﻿using CarSale.Core.Contracts;

namespace CarSale.Core.Models.Offer
{
    public class OfferDetailsViewModel : IOfferModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
        
        public string CarModel { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;
    }
}
