using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciamentoPedidoEstoqueChallenge.CrossCutting
{
    public static class ConfigurationIOC
    {
        public static IServiceCollection AddDbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var server = configuration["DbServer"] ?? "sql1";
            var port = configuration["DbPort"] ?? "1433";
            var user = configuration["DbUser"] ?? "sa";
            var password = configuration["Password"] ?? "GerenciadorPedidoEstoque*2024";
            var database = configuration["Database"] ?? "GerenciadorPedidoEstoqueDatabase";

            var connectionString = $"Server={server},{port};Initial Catalog={database};User ID={user};Password={password};TrustServerCertificate=True";

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }

        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
