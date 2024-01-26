
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using StartupCase_DataAccess.Concrate.Ef;
using StartupCase_DataAccess.Abstract;
using StartupCase_Business.Abstract;
using StartupCase_Business.Concrete;

namespace StartupCase_Business.Service

{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<ICategoryDal,EfCategoryDal>();   
            services.AddScoped<ICategoryService,CategoryManager>();

            services.AddScoped<IProductFilterDal, EfProductFilter>();
            services.AddScoped<IProductFilterService,ProductFilterManager>();

            services.AddScoped<IProductFilterValueDal, EfProductFilterValueDal>();
            services.AddScoped<IProductFilterValueService,ProductFilterValueManager>();

            return services;
        }
    }
}
