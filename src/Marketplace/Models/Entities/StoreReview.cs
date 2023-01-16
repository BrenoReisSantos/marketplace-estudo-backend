using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class StoreReview
{
    public StoreReviewId StoreReviewId { get; init; } = StoreReviewId.New();
    public Store Store { get; init; } = new Store();
    public Review Review { get; init; } = new Review();

}

[StronglyTypedId]
public partial struct StoreReviewId { }
