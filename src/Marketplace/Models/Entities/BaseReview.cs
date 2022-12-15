namespace Marketplace.Models.Entities;

public abstract class BaseReview
{
    public ReviewId Id { get; init; } = ReviewId.New();
    public double Rating { get; set; }
    public string Content { get; init; } = string.Empty;
    public UserId UserId { get; init; } = UserId.New();
}

public record ReviewId(Guid Value)
{
    public static ReviewId New() => new(Guid.NewGuid());
}