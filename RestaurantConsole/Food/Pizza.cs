// Encapsulation: Each food type encapsulates the details of its properties and hides its implementation details.
public class Pizza : IFood
{
    // The properties here represent attributes of a Pizza
    public string Name => "Pizza";
    // Lambda expression is a concise way to represent anonymous methods. 
    // Here, it provides the dictionary for pizza ingredients.
    public IList<Ingredient> Ingredients => new List<Ingredient>
    {
        new Ingredient { Name = "Flour", Quantity = 200 },
        new Ingredient { Name = "Cheese", Quantity = 100 },
        new Ingredient { Name = "Tomato Sauce", Quantity = 150 },
        new Ingredient { Name = "Pepperoni", Quantity = 100 }
    };
    public int CookTime => 20;
    public int Calories => 800;
}
