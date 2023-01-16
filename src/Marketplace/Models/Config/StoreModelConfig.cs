using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class StoreModelConfig : IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder
            .Property(store => store.StoreId)
            .HasConversion<StoreId.EfCoreValueConverter>();

        builder
            .HasIndex(store => store.Cnpj);

        builder
            .HasIndex(store => store.Email)
            .IsUnique();

        builder
            .Property(store => store.Name)
            .HasMaxLength(60);

        builder
            .HasIndex(store => store.Phone)
            .IsUnique();
    }
}
