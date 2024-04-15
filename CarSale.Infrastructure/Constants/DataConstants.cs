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

            public const int PhoneMaxLength = 15;
            public const int PhoneMinLength = 7;
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
        
        public static class Offer
        {
            public const string HorsePowerMaximum = "1000";
            public const string HorsePowerMinimum = "0";

            public const int CarModelMaxLength = 20;
            public const int CarModelMinLength = 1;

            public const int DescriptionMaxLength = 200;
            public const int DescriptionMinLength = 5;

            public const string PriceMaximum = "1000000";
            public const string PriceMinimum = "0";

            public const string YearMaximum = "2024";
            public const string YearMinimum = "1950";

            public const string MilageMaximum = "1000000";
            public const string MilageMinimum = "0";

            public const int TitleMaxLength = 71;
            public const int TitleMinLength = 4;
        }
        
        public static class Transmission
        {
            public const int NameMaxLength = 20;
            public const int NameMinLength = 2;
        }
    }
}

