using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PostgresSample.Data;
using Volo.Abp.DependencyInjection;

namespace PostgresSample.EntityFrameworkCore;

public class EntityFrameworkCorePostgresSampleDbSchemaMigrator
    : IPostgresSampleDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePostgresSampleDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PostgresSampleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PostgresSampleDbContext>()
            .Database
            .MigrateAsync();
    }
}
