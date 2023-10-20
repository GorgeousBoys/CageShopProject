using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class UserDAO
    {
        // Using Singleton pattern
        private static UserDAO instance = null;
        private static object instanceLook = new object();

        public static UserDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<User> GetAllMember()
        {
            IEnumerable<User> users = null;

            try
            {
                var context = new CageShopUniContext();
                users = context.Users;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return users;
        }

        public User Login(string username, string password)
        {
            IEnumerable<User> userList = GetAllMember();
            User user = userList.SingleOrDefault(us => us.UserName.Equals(username, StringComparison.Ordinal) && us.UserPassword.Equals(password, StringComparison.Ordinal));
            return user;
        }
    }
}
