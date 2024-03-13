using ECommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=ECommerceAPIDB;"));
        }
    }
}
