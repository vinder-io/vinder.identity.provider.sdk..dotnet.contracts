namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.User;

public sealed record UserDetails
{
    public string Id { get; init; } = default!;
    public string Username { get; init; } = default!;
}