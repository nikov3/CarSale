﻿using System.ComponentModel.DataAnnotations;

namespace CarSale.Core.Models.Offer
{
    public class OfferServiceModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        //public string Model { get; set; }

        [Display(Name ="Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        public decimal Price {  get; set; }
    }
}