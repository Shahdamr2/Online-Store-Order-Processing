using System.Security.Cryptography.X509Certificates;
using Online_Store_Order_Processing.Data;
using Online_Store_Order_Processing.Models;

namespace Online_Store_Order_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = ProductCatalog.Products;
            #region Task 01 - Smart Product Search

            //// Func<Product, bool> is used because the filter
            //// takes a Product and returns true or false.

            //static List<Product> SearchProducts(List<Product> products,Func<Product, bool> filter)
            //{
            //    List<Product> result = new();

            //    foreach (Product product in products)
            //    {
            //        if (filter(product))
            //        {
            //            result.Add(product);
            //        }
            //    }

            //    return result;
            //}


            //// 1. All Electronics products
            //List<Product> electronics = SearchProducts(catalog, p => p.Category == "Electronics");

            //Console.WriteLine("--- Electronics ---");

            //foreach (Product product in electronics)
            //{
            //    Console.WriteLine(
            //        $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}


            //// 2. Products cheaper than $50
            //List<Product> under50 = SearchProducts(catalog, p => p.Price < 50);

            //Console.WriteLine();
            //Console.WriteLine("--- Under $50 ---");

            //foreach (Product product in under50)
            //{
            //    Console.WriteLine(
            //        $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}


            //// 3. Products that are in stock
            //List<Product> inStock = SearchProducts(catalog, p => p.Stock > 0);

            //Console.WriteLine();
            //Console.WriteLine("--- In Stock ---");

            //foreach (Product product in inStock)
            //{
            //    Console.WriteLine(
            //        $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}


            //// 4. Clothing products under $100
            //List<Product> clothingUnder100 =SearchProducts(catalog,p => p.Category == "Clothing" && p.Price < 100);

            //Console.WriteLine();
            //Console.WriteLine("--- Clothing Under $100 ---");

            //foreach (Product product in clothingUnder100)
            //{
            //    Console.WriteLine(
            //        $"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}

            #endregion
            #region Task 03.1 - Print Reports

            //// Action<Product> is used because we want to perform an action
            //// on each product without returning a value.

            //static void PrintReport(List<Product> products,Action<Product> action)
            //{
            //    foreach (Product product in products)
            //    {
            //        action(product);
            //    }
            //}


            //// Scenario 1 - Short Report

            //Console.WriteLine();
            //Console.WriteLine("--- Short Report ---");

            //PrintReport(catalog, p =>
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price}");
            //});


            //// Scenario 2 - Detailed Report

            //Console.WriteLine();
            //Console.WriteLine("--- Detailed Report ---");

            //PrintReport(catalog, p =>
            //{
            //    Console.WriteLine(
            //        $"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}");
            //});

            #endregion
            #region Task 03.2 - Transform Products

            // Func<Product, string> is used because we take a Product
            // and return a transformed string.

            static List<string> TransformProducts(
                List<Product> products,
                Func<Product, string> transform)
            {
                List<string> result = new();

                foreach (Product product in products)
                {
                    result.Add(transform(product));
                }

                return result;
            }


            // Scenario 3 - Summary List

            Console.WriteLine();
            Console.WriteLine("--- Summary List ---");

            List<string> summary = TransformProducts(
                catalog,
                p => $"{p.Name} (${p.Price})"
            );

            foreach (string item in summary)
            {
                Console.WriteLine(item);
            }


            // Scenario 4 - Price Labels

            Console.WriteLine();
            Console.WriteLine("--- Price Labels ---");

            List<string> priceLabels = TransformProducts(
                catalog,
                p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}"
            );

            foreach (string item in priceLabels)
            {
                Console.WriteLine(item);
            }

            #endregion


        }
    }
}
