namespace Marketplace.Models.Entities;

public class ItemReview : BaseReview
{
    public ItemId ItemId { get; init; } = ItemId.New();
}
