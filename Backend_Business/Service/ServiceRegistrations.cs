using Backend_Business.ClientConnection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
namespace Backend_Api.Service

{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IHttpClientCall, HttpClientCall>();


            return services;
        }
    }
}
