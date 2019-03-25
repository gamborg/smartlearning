namespace DBA.Models
{
    using System;

    public class ProductViewModel
    {
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public DateTime Added { get; set; } 
    }

    public class CarViewModel : ProductViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public DateTime Year { get; set; }
    }
}