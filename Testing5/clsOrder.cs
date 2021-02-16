using System;

namespace Testing5
{
    public class clsOrder
    {
        internal string Description;

        public bool Active { get; internal set; }
        public int OrderId { get; internal set; }
        public int Price { get; internal set; }
        public DateTime Order_date { get; internal set; }
        public int ItemId { get; internal set; }
        public int Size { get; internal set; }
        public int Quantity { get; internal set; }
    }
}