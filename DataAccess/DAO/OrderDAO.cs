using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        private static object instanceLock = new object();

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<Order> GetOrders()
        {
            using var context = new CageShopUni_Context();
            return context.Orders.ToList();
        }

        public Order FindByID(int id)
        {
            using var context = new CageShopUni_Context();
            return context.Orders.SingleOrDefault(order => order.OrderId == id);
        }

        public void AddOrder(Order order)
        {
            using var context = new CageShopUni_Context();
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            using var context = new CageShopUni_Context();
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            using var context = new CageShopUni_Context();
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
