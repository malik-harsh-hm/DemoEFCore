using ContosoPizza.DBFirst.Data;
using ContosoPizza.DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ContosoPizzaDbfirstContext())
            {
                // Create
                var order = new Order()
                {
                    OrderPlaced = DateTime.Now,
                    OrderFulfilled = DateTime.Now,
                    CustomerId = 1
                };
                context.Orders.Add(order);
                // Update
                var customer = context.Customers.SingleOrDefault(c => c.Id == 1);
                if (customer != null)
                    customer.Email = "updated@yopmail.com";
                // Remove
                var anotherCustomer = context.Customers.SingleOrDefault(c => c.Id == 2);
                if(anotherCustomer != null)
                    context.Customers.Remove(anotherCustomer);
                // Inspect Change Tracker
                var entries = context.ChangeTracker.Entries();
                foreach (var entry in entries)
                {
                    Console.WriteLine($"Entry {entry.Metadata.Name} state is {entry.State}");                   
                }


                //var customers = context.Customers
                //    .Include(c => c.Orders)
                //    .ThenInclude(o => o.OrderDetails)
                //    .ThenInclude(od => od.Product)
                //    .AsSplitQuery()
                //    .ToList();

                //foreach (var customer in customers)
                //{
                //    Console.WriteLine($"Customer: {customer.FirstName}");

                //    foreach (var order in customer.Orders)
                //    {
                //        Console.WriteLine($"  Order placed : {order.OrderPlaced}");
                //    }
                //}


                // -------------- Read ----------------

                // LINQ Syntax
                //var query1 = from p in context.Products
                //             where p.Price > 10.00M
                //             orderby p.Price
                //             select p;

                // Extension Method

                // SQL does not execute here

                //// LINQ
                //IQueryable<Product> products1 = context.Products
                //                                .Where(p => p.Price > 10.00M)
                //                                 .OrderBy(p => p.Price);

                //// Raw SQL
                //string sql = "SELECT * FROM Products WHERE Price > 10.00 ORDER BY Price";

                //IQueryable<Product> products2 = context.Products.FromSqlRaw(sql);


                //foreach (var p in ordered)
                //{
                //    Console.WriteLine($"{p.Id} | {p.Name} | {p.Price}");
                //}




                //// ------------- Inner join -------------
                //var query3 = from o in context.Orders
                //             select new { OrderId = o.Id, CustomerName = o.Customer.FirstName };

                //var query4 = from o in context.Orders
                //             join c in context.Customers on o.CustomerId equals c.Id
                //             select new { OrderId = o.Id, CustomerName = c.FirstName };

                //var query5 = context.Orders.Join(context.Customers,
                //    o => o.CustomerId,
                //    c => c.Id,
                //    (o, c) => new { OrderId = o.Id, CustomerName = c.FirstName }
                //    );

                //foreach (var obj in query4)
                //{
                //    Console.WriteLine($"{obj.OrderId} | {obj.CustomerName}");
                //}




                Console.ReadKey();
            }
        }
    }
}
