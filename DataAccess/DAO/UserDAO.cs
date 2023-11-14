using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
                var context = new CageShopUni_Context();
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
           var db = new CageShopUni_Context();
            return db.Users.SingleOrDefault(u => u.UserName.Equals(username) && u.UserPassword.Equals(password));
        }

        // Hàm này để lấy role nếu người dùng nhập username
        // Trả về role name để check chuyển sang form khác nhau
        public string getUserRole(string username)
        {
            string roleName = null;

            try
            {
                var context = new CageShopUni_Context();
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

        // register ShopKeeper's account
        public void registerShopKeeperAccount(User user)
        {
            var context = new CageShopUni_Context();

            // set role là Shopkeeper
            // trên winform kh có phần để user nhập role
            user.RoleId = 3;
            user.Role.RoleName = "Shopkeeper";
            // check input
            if (user ==null)
            {
                throw new Exception("Member is undefined!!");
            }

            //  check database
            if (getUserByUserId(user.UserId) == null )
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("User is existed!!");
            }
        }
        public User getUserByUserId(int id)
        {
            try
            {
                var context = new CageShopUni_Context();
                return context.Users.SingleOrDefault(u => u.UserId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
