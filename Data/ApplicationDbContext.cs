using AppWithDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWithDatabase.Data;

public class ApplicationDbContext : DbContext
{
    // Think of this like a table in our database - it holds pizza orders
    public DbSet<PizzaOrderModel>? PizzaOrders { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
}
