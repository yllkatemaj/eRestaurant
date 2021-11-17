using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public  DateTime Date { get; set; }
        public OrderDetails OrderDetails { get; set; }
    }
}
