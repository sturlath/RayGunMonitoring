using System;
using System.Collections.Generic;
using System.Text;
using RayGunMonitoring.Localization;
using Volo.Abp.Application.Services;

namespace RayGunMonitoring;

/* Inherit your application services from this class.
 */
public abstract class RayGunMonitoringAppService : ApplicationService
{
    protected RayGunMonitoringAppService()
    {
        LocalizationResource = typeof(RayGunMonitoringResource);
    }
}
