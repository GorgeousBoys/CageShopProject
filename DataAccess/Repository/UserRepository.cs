using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
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
    }
}
