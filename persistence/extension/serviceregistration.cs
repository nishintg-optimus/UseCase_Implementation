using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Extensions.DependencyInjection;
//using UseCaseRJ.persistence;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;
//using Microsoft.Extensions.Configuration;

//namespace UseCaseRJ.persistence.extension
//{
//    public static class serviceregistration
//    {
//        public static IServiceCollection AddPersistenceService(this IServiceCollection services, string connectionstring)
//        {
//            services.AddDbContext<UseCaseRJDbContext>(options => options.UseSqlServer(connectionstring));
//            return services;
//        }
//    }
//}
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UseCaseRJ.persistence;

namespace UseCaseRJ.persistence.extension
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<UseCaseRJDbContext>(ng=>
                ng.UseSqlServer(connectionString));

            return services;
        }
    }
}
