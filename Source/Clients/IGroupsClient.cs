namespace Vinder.IdentityProvider.Sdk.Contracts.Clients;

public interface IGroupsClient
{
    public Task<Result<GroupDetails>> CreateGroupAsync(
        GroupForCreation group,
        CancellationToken cancellation = default
    );

    public Task<Result<GroupDetails>> UpdateGroupAsync(
        GroupUpdateContext group,
        CancellationToken cancellation = default
    );

    public Task<Result> DeleteGroupAsync(
        Guid groupId,
        CancellationToken cancellation = default
    );

    public Task<Result<GroupDetails>> AssignGroupPermissionAsync(
        AssignGroupPermission data,
        CancellationToken cancellation = default
    );

    public Task<Result> RevokeGroupPermissionAsync(
        Guid groupId,
        Guid permissionId,
        CancellationToken cancellation = default
    );

    public Task<Result<IReadOnlyCollection<PermissionDetails>>> GetGroupPermissionsAsync(
        Guid groupId,
        ListGroupPermissionsParameters? parameters = null,
        CancellationToken cancellation = default
    );
}
