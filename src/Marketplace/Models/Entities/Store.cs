namespace Marketplace.Models.Entities;

public class Store
{
    public StoreId Id { get; init; } = StoreId.New();
    public string Name { get; init; } = string.Empty;
    public string Cnpj { get; init; } = string.Empty;
    public string Cep { get; init; } = string.Empty;
    public int Number { get; init; }
    public IEnumerable<Item> Items { get; init; } = Enumerable.Empty<Item>();
}

public record StoreId(Guid Value)
{
    public static StoreId New() => new(Guid.NewGuid());
}
