namespace Marketplace.Models.Entities;

public class Store
{
    public StoreId Id { get; init; } = StoreId.New();
    public string Cnpj { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Cep { get; init; } = string.Empty;
    public int Number { get; set; }
    public string Phone { get; init; } = string.Empty;
    public double Rating { get; set; }
    public UserId UserId { get; init; } = UserId.New();
    public IEnumerable<Item> Items { get; init; } = Enumerable.Empty<Item>();
}

public record StoreId(Guid Value)
{
    public static StoreId New() => new(Guid.NewGuid());
}
