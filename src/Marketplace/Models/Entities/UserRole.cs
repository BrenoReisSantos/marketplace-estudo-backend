using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class UserRole
{
    public UserRoleId UserRoleId { get; init; } = UserRoleId.New();
    public RoleType RoleType { get; set; } = RoleType.ConsumerOnly;
    public IEnumerable<User> Users { get; init; } = Enumerable.Empty<User>();
}

[StronglyTypedId]
public partial struct UserRoleId { }

public enum RoleType : byte
{
    ConsumerOnly,
    Seller,
    Administrator
}
