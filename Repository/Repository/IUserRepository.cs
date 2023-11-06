using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository 
    {
        public IEnumerable<User> GetAllUser();
        public User Login(string username, string password);
        public string getUserRole(string username);
        public void registerShopKeeperAccount (User user);
<<<<<<< Updated upstream:DataAccess/Repository/IUserRepository.cs

=======
>>>>>>> Stashed changes:Repository/Repository/IUserRepository.cs
        public User getUserByUserId(int id);
    }
}
