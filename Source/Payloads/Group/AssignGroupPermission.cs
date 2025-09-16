namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.Group;

public sealed record AssignGroupPermission
{
    [JsonIgnore]
    public Guid GroupId { get; init; }

    public string PermissionName { get; init; } = default!;
}
