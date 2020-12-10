using Volo.Abp.Settings;

namespace MeterReading.Settings
{
    public class MeterReadingSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MeterReadingSettings.MySetting1));
        }
    }
}
