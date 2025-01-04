using System;

namespace CarGo.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Fuel { get; set; }
        public int? Hp { get; set; }
        public string Transmission { get; set; }
        public int Km { get; set; }
        public string Color { get; set; }
        public string EmissionClass { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public User Seller { get; set; }
    }
}
