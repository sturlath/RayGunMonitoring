using RayGunMonitoring.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RayGunMonitoring.Permissions;

public class RayGunMonitoringPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RayGunMonitoringPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RayGunMonitoringPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RayGunMonitoringResource>(name);
    }
}
