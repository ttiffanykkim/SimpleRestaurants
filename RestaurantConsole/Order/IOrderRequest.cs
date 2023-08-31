// Abstraction: Interface that defines the contract for Orders.
public interface IOrderRequest
{
    IDictionary<IFood, int> Quantities { get; }
}