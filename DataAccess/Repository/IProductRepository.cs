using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product FindByID(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
<<<<<<< Updated upstream
        IEnumerable<Product> FilterByPrice(bool check);
        IEnumerable<Product> FilterByCategory(string categoryName);
        IEnumerable<Product> FilterByQuantity(bool check);
        IEnumerable<Product> FilterByMaterial(string material);
        IEnumerable<Product> FilterBySize(string size);
        IEnumerable<Product> FilterByStatus(int status);
        IEnumerable<Product> FilterByBar(bool check);
=======
>>>>>>> Stashed changes
    }
}
