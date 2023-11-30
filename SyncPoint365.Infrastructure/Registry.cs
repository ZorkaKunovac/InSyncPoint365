using Microsoft.Extensions.DependencyInjection;

using SyncPoint365.Infrastructure.Repositories;
using SyncPoint365.Infrastructure.Interfaces.Repositories;

namespace SyncPoint365.Infrastructure
{
    public static class Registry
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<ICitiesRepository, CitiesRepository>();
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<ICompaniesRepository, CompaniesRepository>();
            services.AddScoped<IAbsenceRequestsRepository, AbsenceRequestsRepository>();
        }
    }
}
