using Contracts;
using entities;
using LoggerSevice;
using Microsoft.EntityFrameworkCore;

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
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();           
        }

        public static void ConfigureMySqlContext(this IServiceCollection Services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            Services.AddDbContext<RepositoryContext>(object =>
                o.UseMySql(connectionString, serverVersion));
        }
    }
}