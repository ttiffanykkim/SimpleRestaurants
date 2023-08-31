public class Pasta : IFood
{
    public string Name => "Pasta";
    public IList<Ingredient> Ingredients => new List<Ingredient>
    {
        new Ingredient { Name = "Pasta", Quantity = 200 },
        new Ingredient { Name = "Olive Oil", Quantity = 50 },
        new Ingredient { Name = "Garlic", Quantity = 10 },
        new Ingredient { Name = "Tomato Sauce", Quantity = 150 },
        new Ingredient { Name = "Parmesan Cheese", Quantity = 50 }
    };
    public int CookTime => 25;
    public int Calories => 550;
}
