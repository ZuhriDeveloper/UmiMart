using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UMApplication.Application.Common.Interfaces;

namespace UMApplication.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UMApplicationDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<UMApplicationDBContext>());

            return services;
        }
    }
}
