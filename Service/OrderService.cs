using Access;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService
    {
        private OrderAccess orderAccess;
        public bool CreateOrder(Order order)
        {
            orderAccess = new OrderAccess();
            return orderAccess.CreateOrder(order);
        }
    }
}
