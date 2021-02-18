using System;

namespace TestingOrder
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set; }
        public bool Payment { get; set; }
        public DateTime ShippingDate { get; set; }
        public string ShippingAddress { get; set; }
    }
}