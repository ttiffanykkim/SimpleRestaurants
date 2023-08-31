public class OrderRequest : IOrderRequest
{
    public IDictionary<IFood, int> Quantities { get; set; }
}