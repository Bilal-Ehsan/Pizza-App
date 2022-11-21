using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

#nullable disable

namespace AppWithDatabase.Pages.Forms;

public class CustomPizzaModel : PageModel
{
    [BindProperty]
    public Models.PizzaModel Pizza { get; set; }
    public double PizzaPrice { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;

        if (Pizza.TomatoSauce) PizzaPrice += 1;
        if (Pizza.Cheese) PizzaPrice += 1;
        if (Pizza.Pepperoni) PizzaPrice += 1;
        if (Pizza.Mushroom) PizzaPrice += 1;
        if (Pizza.Tuna) PizzaPrice += 1;
        if (Pizza.Pineapple) PizzaPrice += 10;
        if (Pizza.Ham) PizzaPrice += 1;
        if (Pizza.Beef) PizzaPrice += 1;

        // WARNING: Not secure
        return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
    }
}
