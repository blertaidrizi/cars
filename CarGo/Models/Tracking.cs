using System;

namespace CarGo.Models
{
    public class Tracking
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int? TransportId { get; set; }
        public int? InspectorId { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Car Car { get; set; }
    }
}

