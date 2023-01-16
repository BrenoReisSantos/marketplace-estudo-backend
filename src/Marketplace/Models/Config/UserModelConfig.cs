using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class UserModelConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .Property(user => user.UserId)
            .HasConversion<UserId.EfCoreValueConverter>();

        builder
            .HasIndex(user => user.Cpf)
            .IsUnique();

        builder
            .HasIndex(user => user.Email)
            .IsUnique();

        builder
            .HasIndex(user => user.Phone)
            .IsUnique();
    }
}
