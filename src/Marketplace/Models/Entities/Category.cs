using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class Category
{
    public CategoryId CategoryId { get; init; } = CategoryId.New();
    public string Name { get; init; } = string.Empty;
    public IEnumerable<Item> Items { get; init; } = Enumerable.Empty<Item>();
}

[StronglyTypedId]
public partial struct CategoryId
{
}
