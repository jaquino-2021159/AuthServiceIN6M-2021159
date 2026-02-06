using AuthServiceIN6BM.Domain.Interfaces;
using AuthServiceIN6BM.Persistence.Data;
using AuthServiceIN6BM.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuthServiceIN6BM.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UserNpgsql(configuration.GetConnectionString("DefaultConnection"))
        .UseSnakeCaseNamingConvetion());

        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddHealthChecks();

        return services;
    }
    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }



}