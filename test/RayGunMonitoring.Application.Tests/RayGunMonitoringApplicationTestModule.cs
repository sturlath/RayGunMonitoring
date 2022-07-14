using Volo.Abp.Modularity;

namespace RayGunMonitoring;

[DependsOn(
    typeof(RayGunMonitoringApplicationModule),
    typeof(RayGunMonitoringDomainTestModule)
    )]
public class RayGunMonitoringApplicationTestModule : AbpModule
{

}
