using PostgresSample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PostgresSample.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PostgresSampleEntityFrameworkCoreModule),
    typeof(PostgresSampleApplicationContractsModule)
    )]
public class PostgresSampleDbMigratorModule : AbpModule
{

}
