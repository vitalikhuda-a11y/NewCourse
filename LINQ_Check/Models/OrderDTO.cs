public sealed class OrderDto
{
    public int OrderId{get; init;}
    public string CustomerName { get; init; } = "";
     public IReadOnlyList<int> ProductIds{get;init;}= Array.Empty<int>();
     public OrderStatus Status { get; init; }
     public DateTime CreatedAt { get; init; }

}
