namespace TestingOrder
{
    public class clsOrderLine
    {
        public bool Active { get; set; }
        public int OrderLineId { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}