using StronglyTypedIds;

namespace Marketplace.Models.Entities;

public class User
{
    public UserId UserId { get; init; } = UserId.New();
    public string Cpf { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public bool IsActive { get; init; }
    public bool EmailConfirmed { get; init; }
    public UserRole UserRole { get; init; } = UserRole.ConsumerOnly;
}

[StronglyTypedId]
public partial struct UserId
{
}

public enum UserRole : byte
{
    ConsumerOnly,
    Seller,
    Administrator
}
