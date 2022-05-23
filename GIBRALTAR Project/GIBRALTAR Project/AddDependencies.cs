using Microsoft.Extensions.Configuration;
using GIBRALTAR_Project.Business.Interfaces;
using GIBRALTAR_Project.Business;
using GIBRALTAR_Project.DataLayer;
using GIBRALTAR_Project.DataLayer.Interfaces;
namespace Microsoft.Extensions.DependencyInjection
{
    public static class AddDependencies
    {
        public static IServiceCollection BindDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IBusiness, Business>();
            services.AddSingleton<IData, GIBRALTAR_Project.DataLayer.Data>();


            return services;
        }
    }
}