using System;
using System.Collections.Generic;
using System.Linq; 
namespace prjInventoryManagement
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    //Extension methods for List<Product>
    public static class ProductExtensions
    {
       
        //Calculates the total value of all products.
        public static decimal TotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Quantity * p.Price);
        }

        
        //Filters products that are low in stock.
        public static List<Product> LowInStock(this List<Product> products, int threshold)
        {
            return products.Where(p => p.Quantity < threshold).ToList();
        }
    }

}    