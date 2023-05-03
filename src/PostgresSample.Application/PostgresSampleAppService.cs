using System;
using System.Collections.Generic;
using System.Text;
using PostgresSample.Localization;
using Volo.Abp.Application.Services;

namespace PostgresSample;

/* Inherit your application services from this class.
 */
public abstract class PostgresSampleAppService : ApplicationService
{
    protected PostgresSampleAppService()
    {
        LocalizationResource = typeof(PostgresSampleResource);
    }
}
