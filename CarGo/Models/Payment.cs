using System;

namespace CarGo.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Inspection Inspection { get; set; }
    }
}
