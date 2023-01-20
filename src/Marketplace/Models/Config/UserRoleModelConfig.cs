using Marketplace.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marketplace.Models.Config;

public class UserRoleModelConfig : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder
            .Property(UserRole => UserRole.UserRoleId)
            .HasConversion<UserRoleId.EfCoreValueConverter>();

        builder
            .Property(UserRole => UserRole.RoleType)
            .HasConversion<string>();

        builder
            .HasIndex(UserRole => UserRole.RoleType)
            .IsUnique();

        builder.HasData(
            new UserRole[]
            {
                new UserRole{
                    UserRoleId = new UserRoleId(new Guid("5f32b848-3a99-4f4c-b856-f5dd65406bb9")),
                    RoleType = RoleType.ConsumerOnly,
                },
                new UserRole{
                    UserRoleId = new UserRoleId(new Guid("95f3814a-3410-4424-af1a-3d509dd9a923")),
                    RoleType = RoleType.Seller,
                },
                new UserRole{
                    UserRoleId = new UserRoleId(new Guid("ffb27cec-c146-43d9-83df-c20c40d01aff")),
                    RoleType = RoleType.Administrator,
                },
            }
        );
    }
}
