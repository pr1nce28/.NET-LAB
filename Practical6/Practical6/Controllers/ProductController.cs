using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical6.Models;

namespace Practical6.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = GetProducts();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();
            Product product = products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "Dell Inspiron 15",
                    Price = 58000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Smartphone",
                    Description = "Samsung Galaxy S23",
                    Price = 64999,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Description = "Sony WH-1000XM4",
                    Price = 19990,
                    Category = "Audio"
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Keyboard",
                    Description = "Logitech MX Mechanical",
                    Price = 14495,
                    Category = "Peripherals"
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Smartwatch",
                    Description = "Apple Watch SE",
                    Price = 29900,
                    Category = "Wearables"
                }
            };
        }
    }
}