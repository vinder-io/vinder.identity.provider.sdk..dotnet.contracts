namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.Group;

public sealed record GroupForCreation
{
    public string Name { get; init; } = default!;
}