using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class ProductAccess
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
            {
                DatabaseConn.cmd = new SqlCommand("Gastronomy.usp_Product_GetAll", DatabaseConn.conn);
                DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    DatabaseConn.conn.Open();
                    var reader = DatabaseConn.cmd.ExecuteReader();
                    if (!reader.HasRows) throw new Exception();



                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.Id = int.Parse(reader["Id"].ToString());
                        product.Name = reader["Name"].ToString();
                        product.Description = reader["Description"].ToString();
                        product.Price = double.Parse(reader["Price"].ToString());

                        products.Add(product);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return products;
        }

        public List<City> GetCities()
        {
            List<City> cities = new List<City>();
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
            {
                DatabaseConn.cmd = new SqlCommand("Location.usp_City_GetAll", DatabaseConn.conn);
                DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    DatabaseConn.conn.Open();
                    var reader = DatabaseConn.cmd.ExecuteReader();
                    if (!reader.HasRows) throw new Exception();



                    while (reader.Read())
                    {
                        City city = new City();
                        city.Id = int.Parse(reader["Id"].ToString());
                        city.Name = reader["Name"].ToString();
                        city.CountryId = int.Parse(reader["CountryId"].ToString());


                        cities.Add(city);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return cities;
        }
    }
}
