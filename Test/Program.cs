using BusinessObject.Models;
using DataAccess.DAO;
using DataAccess.Repository;

namespace Test
{
    internal class Program
    {
        static ProductRepository productRepository = new ProductRepository();
        static void Main(string[] args)
        {
            //TestAddProduct();
            //TestDeleteProduct();
<<<<<<< Updated upstream
            //TestUpdateProduct();
            var products = productRepository.FilterByBar(false);
            foreach (var product in products)
            {
                Console.WriteLine($"CageID: {product.CageId}, CageName: {product.CageName}, Price: {product.Price}," +
                    $" CategoryID: {product.CategoryId}, Quantity: {product.Quantity}," +
                    $" Material: {product.Material}, Size: {product.Size}, Bar:{product.Bar}, Status: {product.CageStatus}");
=======
            TestUpdateProduct();
            var products = productRepository.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"CageID: {product.CageId}, CageName: {product.CageName}");
>>>>>>> Stashed changes
            }
        }

        static void TestAddProduct()
        {
            

            Product product1 = new() { CageName = "Cage 15", CategoryId = 1, Quantity = 20, Price = 3500, DiscountId = 1, Material = "Wood", Size = "L", Bar = 80, Description = "Test cage", CageStatus = 1 };
            productRepository.AddProduct(product1);

            
        }

        static void TestDeleteProduct()
        {
            Product p = productRepository.FindByID(1006);
            if (p != null)
            {
                productRepository.DeleteProduct(p);
            }
        }

        static void TestUpdateProduct()
        {
            Product p = productRepository.FindByID(1007);
            if (p != null)
            {
                p.CageName = "Cage Update";
                productRepository.UpdateProduct(p);
            }
        }
    }
}