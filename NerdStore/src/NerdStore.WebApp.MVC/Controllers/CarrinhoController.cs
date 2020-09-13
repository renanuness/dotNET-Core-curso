using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Core.Bus;
using NerdStore.Core.Messages.CommomMessages.Notifications;
using NerdStore.Vendas.Application.Commands;

namespace NerdStore.WebApp.MVC.Controllers
{
    public class CarrinhoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly IMediatorHandler _mediatorHandler;

        public CarrinhoController(INotificationHandler<DomainNotification> notification,
                                  IProdutoAppService produtoAppService, 
                                  IMediatorHandler mediatorHandler) : base(notification, mediatorHandler)
        {
            _produtoAppService = produtoAppService;
            _mediatorHandler = mediatorHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("meu-carrinho")]
        public async Task<IActionResult> AdicionarItem(Guid id, int quantidade)
        {
            var produto = await _produtoAppService.ObterPorId(id);
            if ( produto == null ) return BadRequest();

            if(produto.QuantidadeEstoque < quantidade)
            {
                TempData["Erro"] = "Produto com estoque insuficiente";
                return RedirectToAction("ProdutoDetalhe", "Vitrine", new { id });
            }

            var command = new AdicionarItemPedidoCommand(ClienteId, produto.Id, produto.Nome, quantidade, produto.Valor);
            await _mediatorHandler.EnviarComando(command);

            if(OperacaoValida())
            {
                return RedirectToAction("Index");
            }

            //Toda vez ue eu dou um redirect eu perco o estado do request anterior
            TempData["Erros"] = ObterMensagensErro();
            return RedirectToAction("ProdutoDetalhe", "Vitrine", new { id });
        }
    }
}