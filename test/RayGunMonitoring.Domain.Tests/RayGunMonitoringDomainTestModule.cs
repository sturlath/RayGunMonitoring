using RayGunMonitoring.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RayGunMonitoring;

[DependsOn(
    typeof(RayGunMonitoringEntityFrameworkCoreTestModule)
    )]
public class RayGunMonitoringDomainTestModule : AbpModule
{

}
