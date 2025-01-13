namespace CarGo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int BuyerId { get; set; }
        public int? SellerId { get; set; }
        public string? SellerStatus { get; set; }
        public int? InspectorId { get; set; }
        public string? Notes { get; set; }
        public int? TransportId { get; set; }
        public DateTime? OrderedTime { get; set; }
        public DateTime? SoldTime { get; set; }
        public DateTime? InspectedTime { get; set; }
        public DateTime? TransportStart { get; set; }
        public DateTime? TransportFinish { get; set; }
        public int Notify { get; set; }
    }
}
