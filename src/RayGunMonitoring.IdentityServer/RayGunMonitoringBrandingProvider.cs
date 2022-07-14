using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RayGunMonitoring;

[Dependency(ReplaceServices = true)]
public class RayGunMonitoringBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RayGunMonitoring";
}
