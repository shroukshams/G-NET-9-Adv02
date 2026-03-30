using System.Collections.Generic;

namespace G_NET_9_Adv02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Task 01: Smart Product Search ---");
            //ShopMastersCatalog catalog = new ShopMastersCatalog();
            // 1. All Electronics products
            List<Product> electronicsProducts = ShopMasters.SearchProducts(ShopMasters.catalog, p => p.Category == "Electronics");
            Console.WriteLine("\n--- Electronics ---");
            foreach (var p in electronicsProducts)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }

            // 2. Products cheaper than $50
            List<Product> cheaperThan50 = ShopMasters.SearchProducts(ShopMasters.catalog, p => p.Price < 50);
            Console.WriteLine("\n--- Under $50 ---");
            foreach (var p in cheaperThan50)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }

            // 3. Products that are in stock (Stock > 0)
            List<Product> inStockProducts = ShopMasters.SearchProducts(ShopMasters.catalog, p => p.Stock > 0);
            Console.WriteLine("\n--- In Stock ---");
            foreach (var p in inStockProducts)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }

            // 4. Clothing products under $100
            List<Product> clothingUnder100 = ShopMasters.SearchProducts(ShopMasters.catalog, p => p.Category == "Clothing" && p.Price < 100);
            Console.WriteLine("\n--- Clothing under $100 ---");
            foreach (var p in clothingUnder100)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }

            Console.WriteLine("\n--- Task 03: Custom Report Generator ---");

            // 3.1 Print Reports
            Console.WriteLine("\n--- Short Report ---");
            ShopMasters.PrintReport(ShopMasters.catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

            Console.WriteLine("\n--- Detailed Report ---");
            ShopMasters.PrintReport(ShopMasters.catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));

            // 3.2 Transform Products
            Console.WriteLine("\n--- Summary List ---");
            List<string> summaryList = ShopMasters.TransformProducts(ShopMasters.catalog, p => $"{p.Name} (${p.Price})");
            foreach (var item in summaryList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--- Price Labels ---");
            List<string> priceLabels = ShopMasters.TransformProducts(ShopMasters.catalog, p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}");
            foreach (var item in priceLabels)
            {
                Console.WriteLine(item);
            }

            // 3.3 Filter Products
            Console.WriteLine("\n--- Low-Stock Alert ---");
            List<Product> lowStockProducts = ShopMasters.FilterProducts(ShopMasters.catalog, p => p.Stock < 20);
            foreach (var p in lowStockProducts)
            {
                Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
            }

        }
    }

}