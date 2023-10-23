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
                // Lay tat ca Users trong database
                users = context.Users;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return users;
        }

        // Người dùng nhập username và password
        public User Login(string username, string password)
        {
            IEnumerable<User> userList = GetAllMember();
            User user = userList.SingleOrDefault(us => us.UserName.Equals(username) && us.UserPassword.Equals(password));
            return user;
        }

        // Hàm này để lấy role nếu người dùng nhập username
        // Trả về role name để check chuyển sang form khác nhau
        public string getUserRole(string username)
        {
            string roleName = null;

            try
            {
                var context = new CageShopUniContext();
                var user = context.Users.SingleOrDefault(u => u.UserName == username);

                if (user != null && user.Role != null)
                {
                    roleName = user.Role.RoleName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return roleName;
        }
    }
}
