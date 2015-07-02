using System;
using System.Collections.Generic;

namespace Opg2.Model
{
    public class Order : BaseModel
    {
        public Customer Customer { get; set; }
        public List<Product> OrderedProducts { get; set; }
        public int TotalPrice { get; set; }

        public OrderState OrderState { get; set; }
        public String TrackAndTrace { get; set; }
    }

    public enum OrderState
    {
        New,
        Pending,
        Shipped,
        Completed,
        Canceled
    }
}