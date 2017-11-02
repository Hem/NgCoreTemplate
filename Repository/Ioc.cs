using Microsoft.Extensions.DependencyInjection;
using Repository.Contracts;

namespace Repository
{
    public static class Ioc
    {
        public static void AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}