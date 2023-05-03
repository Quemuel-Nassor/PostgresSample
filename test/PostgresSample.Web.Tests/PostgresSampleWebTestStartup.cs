using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace PostgresSample;

public class PostgresSampleWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<PostgresSampleWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
