using System;
using System.Collections.Generic;

namespace AbbysProductShop.Models
{
    public class DataBase
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "My Product",
                    Price = (decimal) 499.00
                },

                new Product
                {
                    ProductId = 2,
                    Name = "Best Product Ever",
                    Price = (decimal)1109.00
                },

                new Product
                {
                    ProductId = 3,
                    Name = "McDonald's Happy Meal and Dessert",
                    Price = (decimal)9.00
                },

                new Product
                {
                    ProductId = 4,
                    Name = "Bourbon",
                    Price = (decimal)29.90
                },

                new Product
                {
                    ProductId = 5,
                    Name = "Tiny Product",
                    Price = (decimal)1.00
                },

                new Product
                {
                    ProductId = 6,
                    Name = "MacBook Pro",
                    Price = (decimal)1780.00
                },

                new Product
                {
                    ProductId = 7,
                    Name = "Best Ever Keyboard",
                    Price = (decimal)69.00
                },

                new Product
                {
                    ProductId = 8,
                    Name = "Lighbulb",
                    Price = (decimal)91.00
                },

                new Product
                {
                    ProductId = 9,
                    Name = "Vodka",
                    Price = (decimal)129.90
                },

                new Product
                {
                    ProductId = 10,
                    Name = "Product Of the Month",
                    Price = (decimal)100.00
                }
            };
            return products; 
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = DataBase.GetProducts();
            foreach(Product p in products)
            {
                if (p.Slug == slug)
                {
                    return p; 
                }
            }
            return null; 
        }
    }
}
