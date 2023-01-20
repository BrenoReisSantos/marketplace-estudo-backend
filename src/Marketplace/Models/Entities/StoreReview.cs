using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class StoreReview
{
    public StoreReviewId StoreReviewId { get; init; } = StoreReviewId.New();
    public Store Store { get; init; } = new();
    public Review Review { get; init; } = new();
    public User User { get; init; } = new();
}

[StronglyTypedId]
public partial struct StoreReviewId
{
}
