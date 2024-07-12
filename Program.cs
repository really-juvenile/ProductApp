using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Models;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductClass product1 = new ProductClass();
            product1.id= 1;
            product1.name = "bag";
            product1.price = 100;
            product1.discountPercentage = 50;

            ProductClass product2 = new ProductClass();
            product2.id = 2;
            product2.name = "lamp";
            product2.price = 200;
            product2.discountPercentage = 50;
            DisplayProduct(product2);
            DisplayProduct(product1);



        }
        static void DisplayProduct(ProductClass product)
        {
            Console.WriteLine("Product_id: "+ product.id);
            Console.WriteLine("product_name: "+product.name);
            Console.WriteLine("price: "+product.price);
            Console.WriteLine("discount percentage: "+product.discountPercentage);
            Console.WriteLine("price after discount" + product.GetDiscountedCost());

        }
    }
}
