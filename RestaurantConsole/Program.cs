var kitchen = new KitchenService(new InMemoryInventoryRepository());

// Display the current Inventory
Console.WriteLine("Current Inventory...");
Console.WriteLine(kitchen.DisplayAvailableIngredients());
Console.WriteLine();

// This is an example of creating an Order object which is composed of food items and their quantities
var order = new OrderRequest
{
    Quantities = new Dictionary<IFood, int>
    {
        { new Pizza(), 2 },
        { new Burger(), 3 }
    }
};

// This order will be failed because of not enough ingredients
var result = kitchen.GetOrder(order);
Console.WriteLine("Order 2 Pizzas, and 3 Burgers...");
Console.WriteLine(result.Message);
Console.WriteLine();

// Adding ingredients
var ingredientsToAdd = new List<Ingredient>
{
    new Ingredient { Name = "Flour", Quantity = 210 },
    new Ingredient { Name = "Cheese", Quantity = 53 },
    new Ingredient { Name = "Pepperoni", Quantity = 55 },
    new Ingredient { Name = "Tomato", Quantity = 10 },
};
Console.WriteLine(kitchen.AddIngredients(ingredientsToAdd));
Console.WriteLine();

// Removing ingredients just for testing
var ingredientsToRemove = new List<Ingredient>
{
    new Ingredient { Name = "Lettuce", Quantity = 3 }
};
Console.WriteLine(kitchen.RemoveIngredients(ingredientsToRemove));
Console.WriteLine();

// Try the order again
Console.WriteLine("Order 2 Pizzas, and 3 Burgers...");
result = kitchen.GetOrder(order);
Console.WriteLine(result.Message);
Console.WriteLine();

// Display the changed inventory
Console.WriteLine("Current Inventory...");
Console.WriteLine(kitchen.DisplayAvailableIngredients());
Console.WriteLine();