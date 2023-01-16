using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class StoreReviewModelConfig : IEntityTypeConfiguration<StoreReview>
{
    public void Configure(EntityTypeBuilder<StoreReview> builder)
    {
        builder
            .Property(storeReview => storeReview.StoreReviewId)
            .HasConversion<StoreReviewId.EfCoreValueConverter>();

        builder.OwnsOne(itemReview => itemReview.Review);
    }
}
