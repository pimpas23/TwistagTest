using TwistagTest.Business.Interfaces;
using TwistagTest.Business.Services;
using TwistagTest.Data.Context;
using TwistagTest.Data.Repository;

namespace TwistagTest.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            return services;
        }
    }
}
