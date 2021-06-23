using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using WeatherForecast.Service;

namespace WeatherForecast
{
    public class ExternalEndpointHealthCheck : IHealthCheck
    {
        private readonly ServiceSettings settings;

        public ExternalEndpointHealthCheck(IOptions<ServiceSettings> options)
        {
            this.settings = options.Value;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            Ping ping = new();

            var reply = await ping.SendPingAsync(settings.OpenWeatherHost);

            if (reply.Status != IPStatus.Success)
                return HealthCheckResult.Unhealthy();

            return HealthCheckResult.Healthy();

        }
    }

}