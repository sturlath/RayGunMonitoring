using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RayGunMonitoring.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class RayGunMonitoringDbContextFactory : IDesignTimeDbContextFactory<RayGunMonitoringDbContext>
{
    public RayGunMonitoringDbContext CreateDbContext(string[] args)
    {
        RayGunMonitoringEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<RayGunMonitoringDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new RayGunMonitoringDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../RayGunMonitoring.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
