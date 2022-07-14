using RayGunMonitoring.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RayGunMonitoring.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RayGunMonitoringEntityFrameworkCoreModule),
    typeof(RayGunMonitoringApplicationContractsModule)
    )]
public class RayGunMonitoringDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
