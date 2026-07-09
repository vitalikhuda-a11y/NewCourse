public sealed class ProductDto
{
   public int Id{get; init;}
   public string Name{  get; init; } ="";
   public required string Category { get; init; }
   public decimal Price { get; init; }
   public int StockCount { get; init; }
   public bool IsAvailable { get; init; }

}
