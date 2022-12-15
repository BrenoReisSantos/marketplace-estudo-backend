using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class CategoryModelConfig : IEntityTypeConfiguration<Category>
{
    public static readonly ValueConverter<CategoryId, Guid> CategoryIdConverter = new(
        categoryId => categoryId.Value,
        guid => new(guid)
    );

    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(category => category.Id);

        builder
            .Property(category => category.Id)
            .HasConversion(CategoryIdConverter);

        builder
            .HasMany<Item>()
            .WithOne()
            .HasForeignKey(item => item.Id);

        builder
            .Property(item => item.Id)
            .HasConversion(ItemModelConfig.ItemIdConverter);
    }
}
