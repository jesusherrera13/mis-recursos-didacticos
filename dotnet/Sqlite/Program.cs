using Sqlite.Shared;
using static System.Console;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace Sqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryingCategories();
            // QueryingProducts("");
            // QueryingProducts("price");
            QueryingProducts("like");
        }

        static void QueryingCategories()
        {
            using (var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                WriteLine("Categories and how many products they have:");
                IQueryable<Category> cats = db.Categories
                    .Include(c => c.Products);

                foreach (Category c in cats)
                {
                    WriteLine($"{c.CategoryName} \thas {c.Products.Count} products.");
                }
            }
        }
        static void QueryingProducts(string option)
        {
            using(var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                WriteLine("Products that cost more than a price, highest at top.");

                IQueryable<Product> prods = null;

                if(option.Equals("price")) {

                    string input;
                    decimal price;
                    
                    do
                    {
                        Write("Enter a product price: ");
                        input = ReadLine();
                    } while(!decimal.TryParse(input, out price));

                    prods = db.Products
                        .Where(product => product.Cost > price)
                        .OrderByDescending(product => (double?) product.Cost);
                }
                else if(option.Equals("like"))
                {
                    Write("Enter part of a product name: ");
                    string input = ReadLine();

                    prods = db.Products
                        .Where(p => EF.Functions.Like(p.ProductName, $"%{input}%"))
                        .OrderByDescending(product => (double?) product.Cost);
                }
                else 
                {
                    prods = db.Products.OrderBy(product => product.ProductName);
                }

                foreach(Product item in prods)
                {
                    Console.WriteLine("{0}: {1} costs {2:$#,##0.00} and has {3} in stock.", item.ProductID, item.ProductName, item.Cost, item.Stock);
                }
            }
        }
    }
}
