﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Infrastructure.Constants
{
    public static class DataConstants
    {
        public static class Brand 
        {
            public const int NameMaxLength = 50; 
            public const int NameMinLength = 2;
        }

        public static class CarType
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;
        }
        public static class City
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;
        }
        public static class Color
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;
        }
        public static class Dealer
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;

            public const int EmailMaxLength = 50;
            public const int EmailMinLength = 2;

            public const int PhoneMaxLength = 10;
            public const int PhoneMinLength = 2;
        }
        
        public static class Fuel
        {
            public const int NameMaxLength = 20;
            public const int NameMinLength = 2;
        }
        public static class Model
        {
            public const int NameMaxLength = 30;
            public const int NameMinLength = 2;
        }
        //public static class Offer
        //{
        //    public const int MilageMaxLength = 50;
        //    public const int MilageMinLength = 2;
        //}
        public static class Transmission
        {
            public const int NameMaxLength = 20;
            public const int NameMinLength = 2;
        }
    }
}
