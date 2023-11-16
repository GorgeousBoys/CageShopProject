using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public interface IUserRepository 
    {
        public IEnumerable<User> GetAllUser();
        public User Login(string username, string password);
        public string getUserRole(string username);
        public void registerShopKeeperAccount (User user);
        public User getUserByUserId(int id);

        void AddUser(User user, string selectedImagePath);
        void UpdateUser(User user);
        void DeleteUser(User user);

        User FindByID(int id);
    }
}
