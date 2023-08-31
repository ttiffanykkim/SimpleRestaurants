// Encapsulation: The InMemoryInventoryRepository encapsulates and manages the in-memory representation of the inventory.
public class InMemoryInventoryRepository : IInventoryRepository
{
    private IDictionary<string, int> _inventory = new Dictionary<string, int>
    {
        {"Flour", 200},
        {"Cheese", 150},
        {"Tomato Sauce", 350},
        {"Pepperoni", 150},
        {"Bun", 10},
        {"Meat Patty", 5},
        {"Lettuce", 50}
    };

    public bool HasIngredients(IList<Ingredient> ingredients)
    {
        foreach (var ingredient in ingredients)
        {
            if (!_inventory.ContainsKey(ingredient.Name) || _inventory[ingredient.Name] < ingredient.Quantity)
            {
                return false;
            }
        }
        return true;
    }

    public IList<Ingredient> GetLackingIngredients(IList<Ingredient> ingredients)
    {
        var lacking = new List<Ingredient>();
        foreach (var ingredient in ingredients)
        {
            var inStock = _inventory.ContainsKey(ingredient.Name) ? _inventory[ingredient.Name] : 0;
            var needed = ingredient.Quantity - inStock;
            if (needed > 0)
            {
                lacking.Add(new Ingredient { Name = ingredient.Name, Quantity = needed });
            }
        }
        return lacking;
    }

    public void AddIngredients(IList<Ingredient> ingredients)
    {
        foreach (var ingredient in ingredients)
        {
            if (_inventory.ContainsKey(ingredient.Name))
            {
                _inventory[ingredient.Name] += ingredient.Quantity;
            }
            else
            {
                _inventory.Add(ingredient.Name, ingredient.Quantity);
            }
        }
    }

    public void RemoveIngredients(IList<Ingredient> ingredients)
    {
        foreach (var ingredient in ingredients)
        {
            if (_inventory.ContainsKey(ingredient.Name))
            {
                _inventory[ingredient.Name] -= ingredient.Quantity;
                // Ensure inventory does not go negative
                if (_inventory[ingredient.Name] < 0)
                {
                    _inventory[ingredient.Name] = 0;
                }
            }
        }
    }

    public IDictionary<string, int> GetInventory()
    {
        // Return a copy to prevent external manipulation of the internal data
        return new Dictionary<string, int>(_inventory);
    }
}
