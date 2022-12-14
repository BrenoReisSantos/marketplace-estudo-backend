namespace Marketplace.Models.Entities;

public class Category
{
    public CategoryId Id { get; init; } = CategoryId.New();
    public string Name { get; init; } = string.Empty;
    public IEnumerable<Item> Items { get; init; } = Enumerable.Empty<Item>();
}

public record CategoryId(Guid Value)
{
    public static CategoryId New() => new(Guid.NewGuid());
}
