using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance = null;
        private static object instanceLook = new object();
        public static RoleDAO Instance { 
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new RoleDAO();
                    }
                    return instance;
                }
            }
        }
        
        public List<Role> GetAll()
        {
            return new CageShopUni_Context().Roles.ToList();
        }
    }
}
