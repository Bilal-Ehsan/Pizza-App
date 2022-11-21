using AppWithDatabase.Data; 
using AppWithDatabase.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

#nullable disable // Because I don't know how to remove the null warning

namespace AppWithDatabase.Pages;

public class OrdersModel : PageModel
{
    public List<PizzaOrderModel> pizzaOrders = new List<PizzaOrderModel>();

    private readonly ApplicationDbContext _context;

    public OrdersModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnGet() 
    { 
        pizzaOrders = _context.PizzaOrders.ToList();
    }
}
