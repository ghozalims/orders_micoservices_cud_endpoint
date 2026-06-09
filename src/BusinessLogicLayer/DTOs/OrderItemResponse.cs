using System;

namespace OrdersMicroservice.BusinessLogicLayer.DTOs
{
    /// <summary>
    /// Represents an item within an order, including product details.
    /// </summary>
    public class OrderItemResponse
    {
        public Guid OrderItemId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        // New properties to include product information
        public string ProductName { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
