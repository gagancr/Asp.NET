using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllProductLibrary
{
    interface IDataCompOfProduct
    {
        void addProduct(Product product);
        void updateProduct(Product product);
        void removeProduct(int productId);
        List<Product> getAllProducts();
    }

     public class ProductRepoClass
    {
        public void addProduct(Product product)
        {
            var context = new ProductEntities();
            context.Products.Add(product);
            context.SaveChanges();
        }
        public List<Product> getAllProducts()
        {
            var context = new ProductEntities();
            List<Product> allProducts = context.Products.ToList();
            return allProducts;
        }

        public void removeProduct(int productId)
        {
            var context = new ProductEntities();
            var found = context.Products.FirstOrDefault((e) => e.ProductId == productId);
            context.Products.Remove(found);
            context.SaveChanges();
        }

        public void updateProduct(Product product)
        {
            var context = new ProductEntities();
            var found = context.Products.FirstOrDefault((e) => e.ProductId == product.ProductId);
            found.ProductName = product.ProductName;
            found.ProductPrice = product.ProductPrice;
            found.ProductQuantity = product.ProductQuantity;

            context.SaveChanges();
        }
    }
}
