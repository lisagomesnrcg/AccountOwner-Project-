using Cntracts;
using LoggerSerevice;


namespace AccountOwnerServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin() // WithOrigins("dominio")
                    .AllowAnyMethod() // WithMethods("GET", "POST")
                    .AllowAnyHeader() // WithHeaders("accept", "content-header")
                );
            });
        }

        public static void configureIISIntegration(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager,LoggerManager>();
        }
    }
}