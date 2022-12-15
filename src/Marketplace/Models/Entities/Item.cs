namespace Marketplace.Models.Entities;

public class Item
{
    public ItemId Id { get; init; } = ItemId.New();
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; set; }
    public string BarCode { get; init; } = string.Empty;
    public double Rating { get; set; }
    public StoreId StoreId { get; init; } = new(Guid.Empty);
    public CategoryId CategoryId { get; init; } = new(Guid.Empty);
}

public record ItemId(Guid Value)
{
    public static ItemId New() => new(Guid.NewGuid());
}
