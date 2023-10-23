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
    }
}
