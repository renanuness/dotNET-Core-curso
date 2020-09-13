using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Data;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catalogo.Domain;
using NerdStore.Catalogo.Domain.Events;
using NerdStore.Core.Bus;
using NerdStore.Core.Messages.CommomMessages.Notifications;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Data;
using NerdStore.Vendas.Data.Repository;
using NerdStore.Vendas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediatorHandler, MediatrHandler>();

            // Notifications
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();

            //Catalogo
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            //
            services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<VendasContext>();
        }
    }
}
