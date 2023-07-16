using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC;

public static class DependencyInjectionApi
{
    public static IServiceCollection AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<IUsuarioRepository , UsuarioRepository>();
        services.AddScoped<IConsultaRepository , ConsultaRepository>();
        services.AddScoped<IExameRepository , ExameRepository>();
        services.AddScoped<ICategoriaRepository , CategoriaRepository>();


        return services;
    }
}
