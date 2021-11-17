using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }

    }
}
