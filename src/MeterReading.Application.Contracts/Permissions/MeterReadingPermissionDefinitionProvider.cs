using MeterReading.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MeterReading.Permissions
{
    public class MeterReadingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MeterReadingPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MeterReadingPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MeterReadingResource>(name);
        }
    }
}
