using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marketplace.Models.Config;

public class ItemReviewModelConfig : IEntityTypeConfiguration<ItemReview>
{
    public void Configure(EntityTypeBuilder<ItemReview> builder)
    {
        builder
            .Property(itemReview => itemReview.ItemReviewId)
            .HasConversion<ItemReviewId.EfCoreValueConverter>();

        builder.OwnsOne(itemReview => itemReview.Review);
    }
}
