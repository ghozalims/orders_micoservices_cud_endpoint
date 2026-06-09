using System;

namespace OrdersMicroservice.BusinessLogicLayer.DTOs
{
    public class OrderResponse
    {
        public Guid OrderID { get; set; }
        public string CustomerName { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class OrderAddRequest
    {
        public string CustomerName { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class OrderUpdateRequest
    {
        public Guid OrderID { get; set; }
        public string? CustomerName { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
