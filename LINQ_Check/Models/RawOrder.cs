public class RawOrder
{
    public int OrderId;
    public int CustomerId;
    public string? CustomerName;
    public List<int>? ProductIds;   // список Id продуктів у замовленні
    public string? Status;          // "pending", "shipped", "cancelled"
    public DateTime CreatedAt;
}