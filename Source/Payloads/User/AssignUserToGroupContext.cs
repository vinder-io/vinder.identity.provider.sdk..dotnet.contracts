namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.User;

public sealed record AssignUserToGroupContext
{
    [JsonIgnore]
    public Guid UserId { get; init; }
    public Guid GroupId { get; init; }
}
