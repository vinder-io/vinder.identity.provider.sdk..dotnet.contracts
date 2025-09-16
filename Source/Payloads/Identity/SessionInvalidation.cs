namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.Identity;

public sealed record SessionInvalidation
{
    public string RefreshToken { get; init; } = default!;
}