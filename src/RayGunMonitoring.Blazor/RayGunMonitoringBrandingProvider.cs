using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace RayGunMonitoring.Blazor;

[Dependency(ReplaceServices = true)]
public class RayGunMonitoringBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RayGunMonitoring";
}
