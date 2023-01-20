using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class Store
{
    public StoreId StoreId { get; init; } = StoreId.New();
    public string Cnpj { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Cep { get; init; } = string.Empty;
    public int Number { get; set; }
    public string Phone { get; init; } = string.Empty;
    public double Rating { get; set; }
    public bool IsActive { get; init; }
    public User User { get; init; } = new();
    public IEnumerable<Item> Items { get; init; } = Enumerable.Empty<Item>();
    public IEnumerable<StoreReview> ItemReviews { get; init; } = Enumerable.Empty<StoreReview>();
}

[StronglyTypedId]
public partial struct StoreId
{
}
