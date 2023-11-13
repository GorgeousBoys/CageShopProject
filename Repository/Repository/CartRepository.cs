using BusinessObject.Objects;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CartRepository : ICartRepository
    {
        public void AddToCart(int productId, int quantity, decimal price) => CartDAO.Instance.AddToCart(productId, quantity, price);

        public void DeleteCart() => CartDAO.Instance.DeleteCart();

        public Dictionary<int, ProductCart> GetCart() => CartDAO.Instance.GetCart();

        public void RemoveFromCart(int productId) => CartDAO.Instance.RemoveFromCart(productId);

        public void UpdateCart(int productId, int quantity, decimal price) => CartDAO.Instance.UpdateCart(productId, quantity, price);
    }
}
