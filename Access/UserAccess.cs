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
    public class UserAccess
    {
        public User Login(User user)
        {

            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
            {
                DatabaseConn.cmd = new SqlCommand("Administration.usp_User_Login", DatabaseConn.conn);
                DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;
                DatabaseConn.cmd.Parameters.AddWithValue("@email", user.Email);
                DatabaseConn.cmd.Parameters.AddWithValue("@password", user.Password);

                try
                {
                    DatabaseConn.conn.Open();
                    var reader = DatabaseConn.cmd.ExecuteReader();
                    if (!reader.HasRows) throw new Exception();

                    User userFromDb = new User();

                    while (reader.Read())
                    {

                        user.Id = int.Parse(reader["Id"].ToString());
                        user.Name = reader["Name"].ToString();
                        user.LastName = reader["LastName"].ToString();
                        user.Email = reader["Email"].ToString();
                        user.Role = reader["RoleName"].ToString();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return user;
        }
    }
}
