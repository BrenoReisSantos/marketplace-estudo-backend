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
            .HasOne<Store>()
            .WithMany()
            .HasForeignKey(item => item.StoreId);

        builder
            .Property(item => item.StoreId)
            .HasConversion(StoreModelConfig.StoreIdConverter);
    }
}
