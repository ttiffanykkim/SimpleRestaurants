public class Salad : IFood
{
    public string Name => "Salad";
    public IList<Ingredient> Ingredients => new List<Ingredient>
    {
        new Ingredient { Name = "Lettuce", Quantity = 100 },
        new Ingredient { Name = "Tomato", Quantity = 50 },
        new Ingredient { Name = "Cucumber", Quantity = 50 },
        new Ingredient { Name = "Olive Oil", Quantity = 20 },
        new Ingredient { Name = "Vinegar", Quantity = 10 }
    };
    public int CookTime => 10;
    public int Calories => 250;
}
