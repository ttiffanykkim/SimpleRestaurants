// Abstraction: Using an interface to define a contract for Food objects.
// This allows various food objects to be defined with common properties but different implementations.
public interface IFood
{
    string Name { get; }
    IList<Ingredient> Ingredients { get; }
    int CookTime { get; }
    int Calories { get; }
}
