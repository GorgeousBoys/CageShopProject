using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product FindByID(int id) => ProductDAO.Instance.FindByID(id);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public void DeleteProduct(Product product) => ProductDAO.Instance.DeleteProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);

        public IEnumerable<Product> FilterByPrice(decimal minPrice, decimal maxPrice)
        {
            return GetProducts().Where(product => product.Price >= minPrice && product.Price <= maxPrice);
        }

        public IEnumerable<Product> SearchByDescriptionKeyword(string keyword)
        {
            keyword = keyword.ToLower(); 
            return GetProducts().Where(product => product.Description?.ToLower().Contains(keyword) == true);
        }

        public IEnumerable<Product> FilterByMaterial(string material)
        {
            material = material.ToLower();
            return GetProducts().Where(product => product.Material?.ToLower() == material);
        }

        public IEnumerable<Product> FilterByBar(string bar)
        {
            bar = bar.ToLower();
            return GetProducts().Where(product => product.Bar?.ToLower() == bar);
        }
    }
}
