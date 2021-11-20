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
    public class OrderAccess
    {
        public bool CreateOrder(Order order)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
            {
                DatabaseConn.cmd = new SqlCommand("Gastronomy.usp_Order_CreateOrder", DatabaseConn.conn);
                DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;
                DatabaseConn.cmd.Parameters.AddWithValue("@userId", order.UserId);
                DatabaseConn.cmd.Parameters.AddWithValue("@restaurantId", order.RestaurantId);
                DatabaseConn.cmd.Parameters.AddWithValue("@cityId", order.CityId);
                DatabaseConn.cmd.Parameters.AddWithValue("@address", order.Address);
                // initialize order details data table

                DatabaseConn.cmd.Parameters.AddWithValue("@tvpProducts", CreateDataTable(order.OrderDetails));




                try
                {
                    DatabaseConn.conn.Open();
                    DatabaseConn.cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable CreateDataTable(OrderDetails od)
        {
            DataTable tvp = new DataTable();
            tvp.Columns.Add("ProductId", typeof(int));
            tvp.Columns.Add("Quantity", typeof(double));
            tvp.Columns.Add("Price", typeof(double));

            var row = tvp.NewRow();

            row["ProductId"] = od.ProductId;
            row["Quantity"] = od.Quantity;
            row["Price"] = od.Price;

            tvp.Rows.Add(row);

            return tvp;
        }
    }
}
