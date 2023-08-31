public interface IInventoryRepository
{
    bool HasIngredients(IList<Ingredient> ingredients);
    IList<Ingredient> GetLackingIngredients(IList<Ingredient> ingredients);
    void AddIngredients(IList<Ingredient> ingredients);
    void RemoveIngredients(IList<Ingredient> ingredients);
    IDictionary<string, int> GetInventory();
}