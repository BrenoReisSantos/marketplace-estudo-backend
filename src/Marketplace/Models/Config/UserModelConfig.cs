using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marketplace.Models.Config;

public class UserModelConfig : IEntityTypeConfiguration<User>
{
    public static readonly ValueConverter<UserId, Guid> UserIdConverter = new(
        UserId => UserId.Value,
        guid => new(guid)
    );

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(user => user.Id);

        builder
            .Property(user => user.Id)
            .HasConversion(UserIdConverter);

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
