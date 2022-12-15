namespace Marketplace.Models.Entities;

public class User
{
    public UserId Id { get; init; } = UserId.New();
    public string Cpf { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public bool CanSell { get; init; }
    public bool IsActive { get; init; }
    public bool EmailConfirmed { get; init; }
}

public record UserId(Guid Value)
{
    public static UserId New() => new(Guid.NewGuid());
}