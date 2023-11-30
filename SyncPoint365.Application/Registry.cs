using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

using SyncPoint365.Application.Services;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Application.Mapping;
using SyncPoint365.Application.Validators;
using SyncPoint365.Core.DTOs.AbsenceRequest;
using SyncPoint365.Core.DTOs.City;
using SyncPoint365.Core.DTOs.Company;
using SyncPoint365.Core.DTOs.Country;
using SyncPoint365.Core.DTOs.User;

namespace SyncPoint365.Application
{
    public static class Registry
    {
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CityAddDTO>, CityAddValidator>();
            services.AddScoped<IValidator<CityUpdateDTO>, CityUpdateValidator>();

            services.AddScoped<IValidator<CountryAddDTO>, CountryAddValidator>();
            services.AddScoped<IValidator<CountryUpdateDTO>, CountryUpdateValidator>();

            services.AddScoped<IValidator<CompanyAddDTO>, CompanyAddValidator>();
            services.AddScoped<IValidator<CompanyUpdateDTO>, CompanyUpdateValidator>();

            services.AddScoped<IValidator<UserAddDTO>, UserAddValidator>();
            services.AddScoped<IValidator<UserUpdateDTO>, UserUpdateValidator>();

            services.AddScoped<IValidator<AbsenceRequestAddDTO>, AbsenceRequestAddValidator>();
            services.AddScoped<IValidator<AbsenceRequestUpdateDTO>, AbsenceRequestUpdateValidator>();
        }

        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICitiesService, CitiesService>();
            services.AddScoped<ICountriesService, CountriesService>();
            services.AddScoped<ICompaniesService, CompaniesService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IAbsenceRequestsService, AbsenceRequestsService>();
        }

        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CityProfile));
        }
    }
}
