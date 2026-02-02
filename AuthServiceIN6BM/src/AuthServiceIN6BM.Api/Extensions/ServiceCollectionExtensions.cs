using AuthServiceIN6BM.Application.Interfaces;
using AuthServiceIN6BM.Domain.Interfaces;
using AuthServiceIN6BM.Persistence.Data;
using AuthServiceIN6BM.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuthServiceIN6BM.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(FileOptions =>
            options.UserNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .UseSnakeCaseNamingConventions());
        
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        
        services.AddHealthChecks();

        return services;
    
    }

    public static IServiceCollection AddApiDocumentation(this IserviceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services:AddSwaggerGen();

        return services;
    }
}