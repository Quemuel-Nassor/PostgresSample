using Volo.Abp.Settings;

namespace PostgresSample.Settings;

public class PostgresSampleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PostgresSampleSettings.MySetting1));
    }
}
