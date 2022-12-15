using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class StoreReviewModelConfig : IEntityTypeConfiguration<StoreReview>
{
    public static readonly ValueConverter<ReviewId, Guid> StoreReviewIdConverter = new(
        storeReviewId => storeReviewId.Value,
        guid => new(guid)
    );

    public void Configure(EntityTypeBuilder<StoreReview> builder)
    {
        builder
            .HasKey(storeReview => storeReview.Id);

        builder
            .Property(storeReview => storeReview.Id)
            .HasConversion(StoreReviewIdConverter);

        builder
            .HasOne<User>()
            .WithOne()
            .HasForeignKey<StoreReview>(storeReview => storeReview.UserId);
    }
}
