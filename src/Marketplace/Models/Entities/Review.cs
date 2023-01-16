using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class Review
{
    public double Rating { get; set; }
    public string? Content { get; init; }
    public User User { get; init; } = new User();
}
