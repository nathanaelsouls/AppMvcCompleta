using System;
using System.Linq;

namespace DevIO.Business.Notificacoes
{
    public class Notificacao
    {
        public string Mensagem { get; }

        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
