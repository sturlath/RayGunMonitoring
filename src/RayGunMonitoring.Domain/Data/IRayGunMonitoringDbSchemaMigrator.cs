using System.Threading.Tasks;

namespace RayGunMonitoring.Data;

public interface IRayGunMonitoringDbSchemaMigrator
{
    Task MigrateAsync();
}
