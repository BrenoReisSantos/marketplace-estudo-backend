using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class CategoryModelConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .Property(category => category.CategoryId)
            .HasConversion<CategoryId.EfCoreValueConverter>();

        builder
            .Property(item => item.CategoryId)
            .HasConversion<CategoryId.EfCoreValueConverter>();
    }
}
