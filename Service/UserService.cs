using Access;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
       public class UserService
    {
        private UserAccess userAccess;

        public User Login(User user)
        {
            userAccess = new UserAccess();
            User db = userAccess.Login(user);
            return db;
        }
    }
}
