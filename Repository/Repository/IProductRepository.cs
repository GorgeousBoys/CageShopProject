using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product FindByID(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        // Filters Product here
        IEnumerable<Product> FilterByPrice(decimal minPrice, decimal maxPrice);
        IEnumerable<Product> SearchByDescriptionKeyword(string keyword);
        IEnumerable<Product> FilterByMaterial(string material);
        IEnumerable<Product> FilterByBar(string bar);
    }
}
