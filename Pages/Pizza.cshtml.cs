using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppWithDatabase.Pages;

public class PizzaModel : PageModel
{
    public List<Models.PizzaModel> fakePizzaDatabase = new List<Models.PizzaModel>
    {
        new Models.PizzaModel { ImageTitle = "margerita", PizzaName = "Majestic Margerita", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 4 },
        new Models.PizzaModel { ImageTitle = "bolognese", PizzaName = "Breezy Bolognese", BasePrice = 2, TomatoSauce = true, Cheese = true, Beef = true, FinalPrice = 5 },
        new Models.PizzaModel { ImageTitle = "hawaiian", PizzaName = "Happy Hawaiian", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 15 },
        new Models.PizzaModel { ImageTitle = "carbonara", PizzaName = "Cool Carbonara", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Mushroom = true, FinalPrice = 6 },
        new Models.PizzaModel { ImageTitle = "meat-feast", PizzaName = "Meat Feast", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 6 },
        new Models.PizzaModel { ImageTitle = "mushroom", PizzaName = "Mushroom Mayhem", BasePrice = 2, TomatoSauce = true, Cheese = true, Mushroom = true, FinalPrice = 5 },
        new Models.PizzaModel { ImageTitle = "pepperoni", PizzaName = "Pepperoni Party", BasePrice = 2, TomatoSauce = true, Cheese = true, Pepperoni = true, FinalPrice = 5 },
        new Models.PizzaModel { ImageTitle = "seafood", PizzaName = "Seafood Surprise", BasePrice = 2, TomatoSauce = true, Cheese = true, Tuna = true, FinalPrice = 5 },
        new Models.PizzaModel { ImageTitle = "vegetarian", PizzaName = "Victorious Vegetarian", BasePrice = 2, TomatoSauce = true, Cheese = true, Mushroom = true, Pineapple = true, FinalPrice = 15 }
    };
}
