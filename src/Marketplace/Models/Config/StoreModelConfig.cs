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
        builder
            .HasKey(store => store.Id);

        builder
            .Property(store => store.Id)
            .HasConversion(StoreIdConverter);

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

        builder
            .Property(store => store.UserId)
            .HasConversion(UserModelConfig.UserIdConverter);

        builder
            .HasMany<StoreReview>()
            .WithOne()
            .HasForeignKey(storeReview => storeReview.Id);

        builder
            .HasMany<Item>()
            .WithOne()
            .HasForeignKey(item => item.Id);
    }
}
