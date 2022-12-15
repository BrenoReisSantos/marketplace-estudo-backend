using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class ItemReviewModelConfig : IEntityTypeConfiguration<ItemReview>
{
    public static readonly ValueConverter<ReviewId, Guid> ItemReviewIdValueConverter = new(
        itemReviewId => itemReviewId.Value,
        guid => new(guid)
    );
    public void Configure(EntityTypeBuilder<ItemReview> builder)
    {
        builder
            .HasKey(itemReview => itemReview.Id);

        builder
            .Property(itemReview => itemReview.Id)
            .HasConversion(ItemReviewIdValueConverter);

        builder.HasOne<User>().WithOne().HasForeignKey<ItemReview>(itemReview => itemReview.UserId);
    }
}
