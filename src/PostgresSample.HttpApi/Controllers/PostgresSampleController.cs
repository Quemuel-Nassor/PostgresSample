using PostgresSample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PostgresSample.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PostgresSampleController : AbpControllerBase
{
    protected PostgresSampleController()
    {
        LocalizationResource = typeof(PostgresSampleResource);
    }
}
