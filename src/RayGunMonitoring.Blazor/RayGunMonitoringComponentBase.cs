using RayGunMonitoring.Localization;
using Volo.Abp.AspNetCore.Components;

namespace RayGunMonitoring.Blazor;

public abstract class RayGunMonitoringComponentBase : AbpComponentBase
{
    protected RayGunMonitoringComponentBase()
    {
        LocalizationResource = typeof(RayGunMonitoringResource);
    }
}
