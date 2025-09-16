namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.Tenant;

public sealed record TenantForCreation
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; } = default!;
}
