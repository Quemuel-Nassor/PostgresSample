using PostgresSample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PostgresSample.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class PostgresSamplePageModel : AbpPageModel
{
    protected PostgresSamplePageModel()
    {
        LocalizationResourceType = typeof(PostgresSampleResource);
    }
}
