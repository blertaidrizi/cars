using System;

namespace CarGo.Models
{
    public class Inspection
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int InspectorId { get; set; }
        public string Status { get; set; }
        public DateTime? ScheduledFromDate { get; set; }
        public DateTime? ScheduledUntilDate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }

        public Car Car { get; set; }
        public User Inspector { get; set; }
    }
}
