using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RayGunMonitoring.Data;

/* This is used if database provider does't define
 * IRayGunMonitoringDbSchemaMigrator implementation.
 */
public class NullRayGunMonitoringDbSchemaMigrator : IRayGunMonitoringDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
