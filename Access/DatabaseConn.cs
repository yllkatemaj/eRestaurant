using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class DatabaseConn
    {
        public static string conString = "Server=DESKTOP-1GKSCNO;Database=ERestaurant;Trusted_Connection=True;MultipleActiveResultSets=true";
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
    }
}
