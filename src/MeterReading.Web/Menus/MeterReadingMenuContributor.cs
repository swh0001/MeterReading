using System.Threading.Tasks;
using MeterReading.Permissions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using MeterReading.Localization;
using MeterReading.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace MeterReading.Web.Menus
{
    public class MeterReadingMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<MeterReadingResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(MeterReadingMenus.Home, l["Menu:Home"], "~/"));
            if (await context.IsGrantedAsync(MeterReadingPermissions.MeterAccount.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(MeterReadingMenus.MeterAccount, l["Menu:MeterAccount"], "/Meters/MeterAccount")
                );
            }
            if (await context.IsGrantedAsync(MeterReadingPermissions.MeterAccountReading.Default))
            {
                context.Menu.AddItem(
                   new ApplicationMenuItem(MeterReadingMenus.MeterAccountReading, l["Menu:MeterAccountReading"], "/Meters/MeterAccountReading")
               );
            }
        }
    }
}
