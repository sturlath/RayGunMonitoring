using RayGunMonitoring.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RayGunMonitoring.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RayGunMonitoringController : AbpControllerBase
{
    protected RayGunMonitoringController()
    {
        LocalizationResource = typeof(RayGunMonitoringResource);
    }
}
