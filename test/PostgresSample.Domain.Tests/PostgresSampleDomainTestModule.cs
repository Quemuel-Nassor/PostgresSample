using PostgresSample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PostgresSample;

[DependsOn(
    typeof(PostgresSampleEntityFrameworkCoreTestModule)
    )]
public class PostgresSampleDomainTestModule : AbpModule
{

}
