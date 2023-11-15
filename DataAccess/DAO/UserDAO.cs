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
            // Check input
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User is undefined!!");
            }

            // set role to Shopkeeper
            user.RoleId = 3;

            using (var context = new CageShopUni_Context())
            {
                try
                {
                    // Check if the user with the same ID already exists in the database
                    if (getUserByUserId(user.UserId) == null)
                    {
                        // Check if the Role property is not null
                        if (user.Role != null)
                        {
                            // Attach the Role entity to the context
                            context.Attach(user.Role);
                        }

                        // Add the user to the context
                        context.Users.Add(user);

                        // Save changes
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("User already exists!!");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it appropriately
                    Console.WriteLine($"Registration failed: {ex.Message}");
                    throw;
                }
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

        public void AddUser(User user)
        {
            using var context = new CageShopUni_Context();
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            using var context = new CageShopUni_Context();
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            using var context = new CageShopUni_Context();
            context.Users.Remove(user);
            context.SaveChanges();
        }
        public User FindByID(int id)
        {
            using var context = new CageShopUni_Context();
            return context.Users.SingleOrDefault(user => user.UserId == id);
        }
    }
}
