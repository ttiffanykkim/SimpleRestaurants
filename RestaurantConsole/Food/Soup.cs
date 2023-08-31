public class Soup : IFood
{
    public string Name => "Soup";
    public IList<Ingredient> Ingredients => new List<Ingredient>
    {
        new Ingredient { Name = "Chicken Broth", Quantity = 500 },
        new Ingredient { Name = "Carrots", Quantity = 50 },
        new Ingredient { Name = "Onions", Quantity = 50 },
        new Ingredient { Name = "Celery", Quantity = 50 },
        new Ingredient { Name = "Chicken", Quantity = 100 }
    };
    public int CookTime => 30;
    public int Calories => 300;
}
