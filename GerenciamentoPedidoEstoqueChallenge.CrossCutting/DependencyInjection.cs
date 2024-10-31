using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Application.Services;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;
using GerenciamentoPedidoEstoqueChallenge.Domain.Services;
using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciamentoPedidoEstoqueChallenge.CrossCutting
{
    public static class DependencyInjection
    {
        public static void RegisterDependecyInjection(this IServiceCollection services)
        {
            //AppService
            services.AddTransient<IClienteAppService, ClienteAppService>();
            services.AddTransient<IFornecedorAppService, FornecedorAppService>();
            services.AddTransient<IPedidoAppService, PedidoAppService>();
            services.AddTransient<IPedidoItemAppService, PedidoItemAppService>();
            services.AddTransient<IProdutoAppService, ProdutoAppService>();
            services.AddTransient<IUsuarioAppService, UsuarioAppService>();

            //Domain
            services.AddTransient<IClienteDomainService, ClienteDomainService>();
            services.AddTransient<IFornecedorDomainService, FornecedorDomainService>();
            services.AddTransient<IPedidoDomainService, PedidoDomainService>();
            services.AddTransient<IPedidoItemDomainService, PedidoItemDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();
            services.AddTransient(typeof(IBaseDomainService<>), typeof(BaseDomainService<>));

            //Repositories
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            services.AddTransient<IPedidoItemRepository, PedidoItemRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            //UnitOfWork
            services.AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }
    }
}
