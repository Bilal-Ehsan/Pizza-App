namespace AppWithDatabase.Models;

public class PizzaOrderModel
{
    public int Id { get; set; }
    public string? PizzaName { get; set; }
    public double BasePrice { get; set; }
}
