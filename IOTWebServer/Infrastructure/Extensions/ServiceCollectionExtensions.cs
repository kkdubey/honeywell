using Microsoft.Extensions.DependencyInjection;
using IOTWebServer.Features.Devices;
using Microsoft.OpenApi.Models;
using IOTWebServer.Data.Repository;

namespace IOTWebServer.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services) => services
                           .AddScoped<IDeviceService, DeviceService>()
                           .AddSingleton<IDeviceRepository, DeviceRepository>();


        public static IServiceCollection AddSwagger(this IServiceCollection services)
            => services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(
                    "v1", 
                    new OpenApiInfo
                    {
                        Title = "IOT WEB API", 
                        Version = "v1"
                    });
            });

        public static void AddApiControllers(this IServiceCollection services)
            => services
                .AddControllers();
    }
}
