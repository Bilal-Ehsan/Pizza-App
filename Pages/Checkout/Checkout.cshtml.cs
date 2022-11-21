using AppWithDatabase.Data;
using AppWithDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

#nullable disable // Because I don't know how to remove the null warning

namespace AppWithDatabase.Pages.Checkout;

[BindProperties(SupportsGet = true)]
public class CheckoutModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public string PizzaName { get; set; }
    public double PizzaPrice { get; set; }

    public string ImageTitle { get; set; }

    public CheckoutModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom";
        if (string.IsNullOrWhiteSpace(ImageTitle)) ImageTitle = "create";

        // Save new pizza order to database

        PizzaOrderModel order = new PizzaOrderModel
        {
            // The Id gets added automatically by the database, so we can omit this
            PizzaName = PizzaName,
            BasePrice = PizzaPrice
        };

        _context.PizzaOrders.Add(order);
        _context.SaveChanges(); // Insert to database
    }
}
