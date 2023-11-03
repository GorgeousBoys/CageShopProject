﻿using BusinessObject.Models;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        private static object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                }
                return instance;
            }
        }



        public List<Product> GetProducts()
        {
            List<Product> products = null;
            try
            {
                using CageShopUni_Context context = new CageShopUni_Context();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("No products available");
            }
            return products;
        }

        public Product FindByID(int id)
        {
            var products = GetProducts();
            Product p = products.SingleOrDefault(x => x.CageId == id);
            return p;
        }

        public void AddProduct(Product product)
        {
            using CageShopUni_Context context = new();
            var products = GetProducts();
            Product p = FindByID(product.CageId);
            if (p == null)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Failed to Add");
            }
        }


        public void UpdateProduct(Product product)
        {
            using CageShopUni_Context context = new();
            Product p = FindByID(product.CageId);
            if (p != null)
            {
                context.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(Product product)
        {
            using CageShopUni_Context context = new();
            var products = GetProducts();
            Product p = FindByID(product.CageId);
            if (p != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("No Product with the CageID exist");
            }
        }
    }
}