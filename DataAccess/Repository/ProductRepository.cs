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
<<<<<<< Updated upstream
        
        public IEnumerable<Product> FilterByPrice(bool check) => ProductDAO.Instance.FilterByPrice(check);

        public IEnumerable<Product> FilterByCategory(string categoryName) => ProductDAO.Instance.FilterByCategory(categoryName);

        public IEnumerable<Product> FilterByQuantity(bool check) => ProductDAO.Instance.FilterByQuantity(check);

        public IEnumerable<Product> FilterByMaterial(string material) => ProductDAO.Instance.FilterByMaterial(material);

        public IEnumerable<Product> FilterBySize(string size) => ProductDAO.Instance.FilterBySize(size);

        public IEnumerable<Product> FilterByStatus(int status) => ProductDAO.Instance.FilterByStatus(status);

        public IEnumerable<Product> FilterByBar(bool check) => ProductDAO.Instance.FilterByBar(check);
=======
>>>>>>> Stashed changes
    }
}
