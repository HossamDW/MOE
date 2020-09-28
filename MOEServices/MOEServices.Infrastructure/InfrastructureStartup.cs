using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MOEServices.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOEServices.Infrastructure
{
    public static class InfrastructureStartup
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            //Register DbContext
            services.AddDbContext<MoeDBContext>(options);

            return services;
        }
    }
}
