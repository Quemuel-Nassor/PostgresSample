using PostgresSample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PostgresSample.Permissions;

public class PostgresSamplePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PostgresSamplePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PostgresSamplePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PostgresSampleResource>(name);
    }
}
