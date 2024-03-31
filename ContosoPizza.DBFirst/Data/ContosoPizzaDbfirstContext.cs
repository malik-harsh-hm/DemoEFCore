using System;
using System.Collections.Generic;
using ContosoPizza.DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.DBFirst.Data;

public partial class ContosoPizzaDbfirstContext : DbContext
{
    public ContosoPizzaDbfirstContext()
    {
    }

    public ContosoPizzaDbfirstContext(DbContextOptions<ContosoPizzaDbfirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    // Compiled query definition
    private static readonly Func<ContosoPizzaDbfirstContext, int, IEnumerable<Order>> my_Func =
        EF.CompileQuery(
            (ContosoPizzaDbfirstContext context, int customerId) =>
            context.Orders.Where(o => o.CustomerId == customerId));

    // Usage of compiled query
    public IEnumerable<Order> GetOrdersByCustomer_Compiled(int customerId)
    {
        return my_Func(this, customerId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
        .UseLazyLoadingProxies()
        .UseSqlServer("Server=.;Database=ContosoPizza.DBFirst;Integrated Security=True;TrustServerCertificate=true;MultipleActiveResultSets=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
