public interface IKitchenService
{
    string AddIngredients(IList<Ingredient> ingredients);
    string RemoveIngredients(IList<Ingredient> ingredients);
    IOrderResponse GetOrder(IOrderRequest order);
    // Polymorphism
    IOrderResponse GetOrder(IFood food, int quantity);
    string DisplayAvailableIngredients();
}