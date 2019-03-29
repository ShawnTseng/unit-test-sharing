
using System.Collections.Generic;

namespace myStore
{
    public class BatchOrder
    {
        public List<Order> OrderList { get; }

        public BatchOrder()
        {
            this.OrderList = new List<Order>();
        }
    }
}