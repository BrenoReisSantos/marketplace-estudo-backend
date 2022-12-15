using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class ItemModelConfig : IEntityTypeConfiguration<Item>
{

    public static readonly ValueConverter<ItemId, Guid> ItemIdConverter = new(
        itemId => itemId.Value,
        guid => new(guid)
    );

    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder
            .HasKey(item => item.Id);

        builder
            .Property(item => item.Id)
            .HasConversion(ItemIdConverter);

        builder
            .Property(item => item.Name)
            .HasMaxLength(60);

        builder
            .HasOne<Store>()
            .WithMany()
            .HasForeignKey(item => item.StoreId);

        builder
            .Property(item => item.StoreId)
            .HasConversion(StoreModelConfig.StoreIdConverter);

        builder
            .HasMany<Category>()
            .WithOne()
            .HasForeignKey(category => category.Id);

        builder
            .Property(item => item.CategoryId)
            .HasConversion(CategoryModelConfig.CategoryIdConverter);

        builder
            .HasMany<ItemReview>()
            .WithOne()
            .HasForeignKey(review => review.Id);
    }
}
