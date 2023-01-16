using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class ItemReview
{
    public ItemReviewId ItemReviewId { get; init; } = ItemReviewId.New();
    public Item Item { get; init; } = new Item();
    public Review Review { get; init; } = new Review();
}

[StronglyTypedId]
public partial struct ItemReviewId { }
