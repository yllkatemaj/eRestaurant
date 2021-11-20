using Access;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private ProductAccess productAccess;

        public List<Product> GetProducts()
        {
            productAccess = new ProductAccess();
            return productAccess.GetProducts();
        }

        public  List<City> GetCities()
        {
            productAccess = new ProductAccess();
            return productAccess.GetCities();
        }
    }
}
