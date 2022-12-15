namespace Marketplace.Models.Entities;

public class StoreReview : BaseReview
{
    public StoreId StoreId { get; init; } = StoreId.New();
}
