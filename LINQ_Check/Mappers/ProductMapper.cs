public static class ProductMapper
{
    public static ProductDto ToDto(RawProduct raw)=> new()
        {
            Id = raw.Id,
            Name = raw.Name?? "Unknown",
            Category = raw.CategoryName??"Unknown",
            Price = (decimal)raw.PriceUsd,
            StockCount = raw.StockCount,
            IsAvailable = raw.IsActive && raw.StockCount>0
    };
    public static List<ProductDto> ToDtoList(List<RawProduct> raws)
    {
        List<ProductDto> productDtos = new();
        foreach( RawProduct n in raws)
        {
            productDtos.Add(ToDto(n));
        }
        return productDtos;
    }

}
