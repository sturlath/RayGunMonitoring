using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RayGunMonitoring.Data;
using Volo.Abp.DependencyInjection;

namespace RayGunMonitoring.EntityFrameworkCore;

public class EntityFrameworkCoreRayGunMonitoringDbSchemaMigrator
    : IRayGunMonitoringDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreRayGunMonitoringDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the RayGunMonitoringDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RayGunMonitoringDbContext>()
            .Database
            .MigrateAsync();
    }
}
