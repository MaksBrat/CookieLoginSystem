using LoginSystem.DAL.Interfaces;
using LoginSystem.DAL.Repositories;
using LoginSystem.Domain.Entity;
using LoginSystem.Service.Implementations;
using LoginSystem.Service.Interfaces;

namespace LoginSystem
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<User>, UserRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
