using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class User
{
    public UserId UserId { get; init; } = UserId.New();
    public string Cpf { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public bool IsActive { get; init; }
    public bool EmailConfirmed { get; init; }
    public IEnumerable<ItemReview> ItemReviews = Enumerable.Empty<ItemReview>();
    public IEnumerable<StoreReview> StoreReviews = Enumerable.Empty<StoreReview>();
    public UserRole UserRole = new();
}

[StronglyTypedId]
public partial struct UserId
{
}
