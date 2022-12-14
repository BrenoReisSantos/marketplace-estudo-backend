using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class StoreModelConfig : IEntityTypeConfiguration<Store>
{
    public static readonly ValueConverter<StoreId, Guid> StoreIdConverter = new(
        storeId => storeId.Value,
        guid => new(guid)
    );

    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder.HasKey(store => store.Id);
        builder.Property(store => store.Id).HasConversion(StoreIdConverter);
        builder.HasIndex(store => store.Cep).IsUnique();
        builder.HasIndex(store => store.Cnpj).IsUnique();
        builder
            .HasMany<Item>()
            .WithOne()
            .HasForeignKey(item => item.Id);
    }
}
