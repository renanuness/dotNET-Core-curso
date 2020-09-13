using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Bus;
using NerdStore.Core.Messages.CommomMessages.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatorHandler _mediatorHandler;

        public ControllerBase(INotificationHandler<DomainNotification> notifications, IMediatorHandler mediatorHandler)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediatorHandler = mediatorHandler;
        }
        
        protected Guid ClienteId = Guid.Parse("ad2753b7-76dd-482c-995c-2b5579f4b1b4");

        protected bool OperacaoValida()
        {
            return !_notifications.TemNotificacao();
        }

        protected IEnumerable<string> ObterMensagensErro()
        {
            return _notifications.ObterNotificacoes().Select(c => c.Value).ToList();
        }

        protected void NotificarEro(string codigo, string mensagem)
        {
            _mediatorHandler.PublicarNotificacao(new DomainNotification(codigo, mensagem));
        }
    }
}
