using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marketplace.Models.Config;

public class ItemModelConfig : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder
            .Property(item => item.ItemId)
            .HasConversion<ItemId.EfCoreValueConverter>();

        builder
            .Property(item => item.Name)
            .HasMaxLength(60);
    }
}
