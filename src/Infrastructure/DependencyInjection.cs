using System.Collections.Generic;
using System.Security.Claims;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Common;
using UMApplication.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace UMApplication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            services.AddScoped<IUserManager, UserManagerService>();
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<IDateTime, MachineDateTime>();
            //  services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.AddDefaultIdentity<ApplicationUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //if (environment.IsEnvironment("Test"))
            //{
            //    services.AddIdentityServer()
            //        .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>
            //        {
            //            options.Clients.Add(new Client
            //            {
            //                ClientId = "UMApplication.IntegrationTests",
            //                AllowedGrantTypes = { GrantType.ResourceOwnerPassword },
            //                ClientSecrets = { new Secret("secret".Sha256()) },
            //                AllowedScopes = { "UMApplication.WebUIAPI", "openid", "profile" }
            //            });
            //        }).AddTestUsers(new List<TestUser>
            //        {
            //            new TestUser
            //            {
            //                SubjectId = "f26da293-02fb-4c90-be75-e4aa51e0bb17",
            //                Username = "AchmadZuhriDeveloper@gmail.com",
            //                Password = "@Dmin123",
            //                Claims = new List<Claim>
            //                {
            //                    new Claim(JwtClaimTypes.Email, "AchmadZuhriDeveloper@gmail.com")
            //                }
            //            }
            //        });
            //}
            //else
            //{
            //    services.AddIdentityServer()
            //        .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();
            //}

            //services.AddAuthentication()
            //    .AddIdentityServerJwt();

            return services;
        }
    }
}
