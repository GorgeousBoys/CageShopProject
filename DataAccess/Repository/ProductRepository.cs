using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product FindByID(int id) => ProductDAO.Instance.FindByID(id);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public void DeleteProduct(Product product) => ProductDAO.Instance.DeleteProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
