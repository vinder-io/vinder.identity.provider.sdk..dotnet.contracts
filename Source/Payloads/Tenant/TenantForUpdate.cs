namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.Tenant;

public sealed record TenantForUpdate
{
    [JsonIgnore]
    public Guid TenantId { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; } = default!;
}