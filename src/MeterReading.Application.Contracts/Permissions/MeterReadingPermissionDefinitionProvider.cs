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

            var meterAccountPermission = myGroup.AddPermission(MeterReadingPermissions.MeterAccount.Default, L("Permission:MeterAccount"));
            meterAccountPermission.AddChild(MeterReadingPermissions.MeterAccount.Create, L("Permission:Create"));
            meterAccountPermission.AddChild(MeterReadingPermissions.MeterAccount.Update, L("Permission:Update"));
            meterAccountPermission.AddChild(MeterReadingPermissions.MeterAccount.Delete, L("Permission:Delete"));

            var meterAccountReadingPermission = myGroup.AddPermission(MeterReadingPermissions.MeterAccountReading.Default, L("Permission:MeterAccountReading"));
            //meterAccountPermission.AddChild(MeterTest2Permissions.MeterAccount.Create, L("Permission:Create"));
            meterAccountReadingPermission.AddChild(MeterReadingPermissions.MeterAccountReading.Update, L("Permission:Update"));
            //meterAccountPermission.AddChild(MeterTest2Permissions.MeterAccount.Delete, L("Permission:Delete"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MeterReadingResource>(name);
        }
    }
}
