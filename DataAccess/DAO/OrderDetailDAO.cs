using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        private static object instanceLock = new object();

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            using var context = new CageShopUni_Context();
            return context.OrderDetails.ToList();
        }

        public OrderDetail FindByID(int id)
        {
            using var context = new CageShopUni_Context();
            return context.OrderDetails.SingleOrDefault(orderDetail => orderDetail.DetailId == id);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            using var context = new CageShopUni_Context();
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            using var context = new CageShopUni_Context();
            context.OrderDetails.Update(orderDetail);
            context.SaveChanges();
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            using var context = new CageShopUni_Context();
            context.OrderDetails.Remove(orderDetail);
            context.SaveChanges();
        }
    }
}
