using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order) => OrderDAO.Instance.AddOrder(order);

        public void DeleteOrder(Order order) => OrderDAO.Instance.DeleteOrder(order);

        public Order FindByID(int id) => OrderDAO.Instance.FindByID(id);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrders();

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
