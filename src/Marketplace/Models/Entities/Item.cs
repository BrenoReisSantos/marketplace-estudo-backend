using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class Item
{
    public ItemId ItemId { get; init; } = ItemId.New();
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; set; }
    public string BarCode { get; init; } = string.Empty;
    public double Rating { get; set; }
    public bool IsActive { get; init; }
    public IEnumerable<Category> Categories { get; init; } = Enumerable.Empty<Category>();
    public IEnumerable<Store> Stores { get; init; } = Enumerable.Empty<Store>();
    public IEnumerable<ItemReview> ItemReviews { get; init; } = Enumerable.Empty<ItemReview>();
}

[StronglyTypedId]
public partial struct ItemId
{
}
