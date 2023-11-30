using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SyncPoint365.API.Config;
using SyncPoint365.Infrastructure;

namespace SyncPoint365.API
{
    public static class Registry
    {
        public static void AddConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtOptionsSection = configuration.GetSection("JWTOptions");
            services.Configure<JWTOptions>(jwtOptionsSection);
            
            var connectionStringsSection = configuration.GetSection("ConnectionStrings");
            services.Configure<ConnectionStrings>(connectionStringsSection);
        }

        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionStringsSection = configuration.GetSection("ConnectionStrings");
            var connectionStrings = connectionStringsSection.Get<ConnectionStrings>();

            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionStrings!.Main));
        }

        public static void AddAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtOptionsSection = configuration.GetSection("JWTOptions");
            var jwtOptions = jwtOptionsSection.Get<JWTOptions>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = jwtOptions.Issuer,
                    ValidAudience = jwtOptions.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Key)),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true
                };
            });
        }
    }
}
