﻿using BusinessObject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class CartDAO
    {
        private static Dictionary<int, ProductCart> cart;
        private CartDAO()
        {

        }

        // Using Singleton Pattern
        private static CartDAO instance = null;
        private static object instanceLock = new object();

        public static CartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CartDAO();
                    }
                    return instance;
                }
            }
        }
        public Dictionary<int, ProductCart> GetCart() => cart;
        public void AddToCart(int productId, int quantity, decimal price)
        {
            // Check existed cart
            if (cart == null)
            {
                cart = new Dictionary<int, ProductCart>();
            }
            // Check existed Product
            if (cart.ContainsKey(productId))
            {
                ProductCart _cartProduct;
                cart.TryGetValue(productId, out _cartProduct);
                quantity = _cartProduct.Quantity + quantity;
                cart[productId] = new ProductCart()
                {
                    Price = price,
                    Quantity = quantity
                };
            }
            else
            {
                // Update cart
                cart.Add(productId, new ProductCart()
                {
                    Quantity = quantity,
                    Price = price
                });
            }


        }
        public void RemoveFromCart(int productId)
        {
            // Check existed cart
            if (cart != null)
            {
                // Check existed book
                if (cart.ContainsKey(productId))
                {
                    cart.Remove(productId);
                    if (cart.Count == 0)
                    {
                        cart = null;
                    }
                }
            }

        }
        public void UpdateCart(int productId, int quantity, decimal price)
        {
            if (cart != null)
            {
                if (cart.ContainsKey(productId))
                {
                    cart[productId] = new ProductCart()
                    {
                        Price = price,
                        Quantity = quantity
                    };
                }
            }
        }

        public void DeleteCart()
        {
            cart = null;
        }
    }
}
