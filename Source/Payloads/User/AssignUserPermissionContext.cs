namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.User;

public sealed record AssignUserPermissionContext
{
    [JsonIgnore]
    public Guid UserId { get; init; }
    public string PermissionName { get; init; } = default!;
}
