using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PostgresSample.Data;

/* This is used if database provider does't define
 * IPostgresSampleDbSchemaMigrator implementation.
 */
public class NullPostgresSampleDbSchemaMigrator : IPostgresSampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
