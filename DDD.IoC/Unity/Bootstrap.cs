using DDD.Infra.Persistence;
using DDD.Infra.Transactions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.IoC.Unity
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<LibraryContext>(options => options.UseSqlServer(conection));
        }
    }
}