using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class ItemReview
{
    public ItemReviewId ItemReviewId { get; init; } = ItemReviewId.New();
    public Item Item { get; init; } = new();
    public Review Review { get; init; } = new();
    public User User { get; init; } = new();
}

[StronglyTypedId]
public partial struct ItemReviewId
{
}
