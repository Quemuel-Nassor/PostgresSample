using Volo.Abp.Modularity;

namespace PostgresSample;

[DependsOn(
    typeof(PostgresSampleApplicationModule),
    typeof(PostgresSampleDomainTestModule)
    )]
public class PostgresSampleApplicationTestModule : AbpModule
{

}
