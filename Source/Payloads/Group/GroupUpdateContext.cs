namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.Group;

public sealed record GroupUpdateContext
{
    [JsonIgnore]
    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
}