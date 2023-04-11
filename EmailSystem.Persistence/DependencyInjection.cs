using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EmailSystem.Application.Interfaces;

namespace EmailSystem.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<EmailSystemDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IEmailSystemDbContext>(provider => provider.GetService<EmailSystemDbContext>());
            return services;
        }
    }
}