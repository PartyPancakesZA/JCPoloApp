using Domain.User;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DotnetIdentity
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDotnetIdentityServices(
            this IServiceCollection services)
        {
            //add identity services and authorization
            services.AddAuthorization();

            //add identity services, authentication and identity information stores
            services.AddIdentityApiEndpoints<UserModel>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
