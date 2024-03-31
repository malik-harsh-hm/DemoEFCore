using ContosoPizza.Data;
using ContosoPizza.Models;

namespace ContosoPizza.CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ContosoPizzaCodefirstContext())
            {
                // Read

                // Fluent API Syntax
                var customers = context.Customers.ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.FirstName}");
                }

                // Fluent API Syntax
                var products = context.Products
                    .Where(p => p.Price > 10.00M)
                    .OrderBy(p => p.Price);

                // LINQ Syntax
                var products_1 = from p in context.Products
                                 where p.Price > 10.00M
                                 orderby p.Price
                                 select p;

                foreach (var p in products)
                {
                    Console.WriteLine($"{p.Id} | {p.Name} | {p.Price}");
                }

                // Create

                var newProducts = new List<Product>() {
                    new Product() { Name = "Pepperoni Pizza", Price = 9M },
                    new Product() { Name = "Marghareta Pizza", Price = 10M },
                    new Product() { Name = "Veggie Pizza", Price = 12M }
                };
                context.Products.AddRange(newProducts);
                context.SaveChanges();

                // Update

                var product = context.Products
                    .Where(p => p.Name == "Pepperoni Pizza")
                    .FirstOrDefault();
                if (product != null)
                {
                    product.Price = 13.99M;
                }

                context.SaveChanges();
            }
        }
    }
}
