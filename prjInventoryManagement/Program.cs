namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> inventory = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Quantity = 5, Price = 15000m },
                new Product { ID = 2, Name = "Mouse", Quantity = 50, Price = 150m },
                new Product { ID = 3, Name = "Keyboard", Quantity = 2, Price = 500m },
                new Product { ID = 4, Name = "Monitor", Quantity = 8, Price = 3000m }
            };

            decimal totalValue = inventory.TotalValue();
            Console.WriteLine($"Total Inventory Value: R{totalValue}");

            // Use extension method to filter lowstock products
            var lowStockItems = inventory.LowInStock(10);
            Console.WriteLine("\nLow Stock Products:");
            foreach (var item in lowStockItems)
            {
                Console.WriteLine($"{item.Name} - Qty: {item.Quantity}");
            }

            var namePriceList = from p in inventory
                                select new { p.Name, p.Price };

            Console.WriteLine("\nProduct Names & Prices:");
            foreach (var item in namePriceList)
            {
                Console.WriteLine($"{item.Name} - R{item.Price}");
            }

            Console.ReadLine();
        }
    }
}
