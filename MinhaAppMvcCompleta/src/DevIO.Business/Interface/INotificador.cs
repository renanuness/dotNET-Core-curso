using DevIO.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Interface
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
