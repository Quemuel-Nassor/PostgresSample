using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PostgresSample.Web;

[Dependency(ReplaceServices = true)]
public class PostgresSampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PostgresSample";
}
