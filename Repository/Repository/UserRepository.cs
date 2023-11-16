using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserRepository : IUserRepository

    {
        public IEnumerable<User> GetAllUser()
        {
            return UserDAO.Instance.GetAllMember();
        }
        public string getUserRole(string username)
        {
            return UserDAO.Instance.getUserRole(username);
        }
        public User Login(string username, string password)
        {
            return UserDAO.Instance.Login(username, password);
        }
        public void registerShopKeeperAccount(User user) => UserDAO.Instance.registerShopKeeperAccount(user);
        public User getUserByUserId(int id)
        {
            return UserDAO.Instance.getUserByUserId(id);
        }

        public void AddUser(User user, string selectedImagePath) => UserDAO.Instance.AddUser(user, selectedImagePath);
        public void UpdateUser(User user, string selectedImagePath) => UserDAO.Instance.UpdateUser(user, selectedImagePath);
        

        public User FindByID(int id) => UserDAO.Instance.FindByID(id);

        public void DeleteUser(User user) => UserDAO.Instance.DeleteUser(user);

        public List<User> GetUsers() => UserDAO.Instance.GetUsers();
    }
}
