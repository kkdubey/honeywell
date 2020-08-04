using Microsoft.AspNetCore.Builder;

namespace IOTWebServer.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerUI(this IApplicationBuilder app)
            => app
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.DocumentTitle = "Swagger UI - IOT API";
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "IOT Web Api");
                });

    }
}
