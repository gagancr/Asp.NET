using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQuantity { get; set; }


    }
    public static class ProductRepo
    {
        public static List<Product> AllProducts => _repo;

          static  List<Product> _repo = new List<Product>();


        static ProductRepo()
        {
            getAll();
        }

        private static void getAll()
        {
            _repo.Add(new Product
            {
                ProductId = 1,
                ProductName = "Iphone",
                ProductPrice = 7214,
                ProductQuantity = 1,
                ProductImage = @".\Images\iphone14.jfif"
            });
            _repo.Add(new Product
            {
                ProductId = 2,
                ProductName = "Car",
                ProductPrice = 65000,
                ProductQuantity = 2,
                ProductImage = @".\Images\Merc.jfif"
            });
            _repo.Add(new Product
            {
                ProductId = 3,
                ProductName = "Laptop",
                ProductPrice = 35000,
                ProductQuantity = 1,
                ProductImage = @".\Images\dellXps.jfif"
            });
            _repo.Add(new Product
            {
                ProductId = 4,
                ProductName = "Mac",
                ProductPrice = 2965,
                ProductQuantity = 3,
                ProductImage = @".\Images\iMac.jfif"
            });

           
        }
        public static void addProduct(Product p) => _repo.Add(p);

        public static void updateProduct(Product product)
        {
            var found = _repo.Find((p) => p.ProductId == product.ProductId);

            found.ProductName = product.ProductName;
            found.ProductPrice = product.ProductPrice;

        }
        public static void deleteProduct(int id)
        {
            var found = _repo.Find((p) => p.ProductId == id);
            _repo.Remove(found);
        }


    }

}