using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatTeste2
{
    public class ChatHub : Hub
    {
        public void Send(string nome, string mensagem)
        {
            Clients.All.broadcastMessage(nome, mensagem);
        }
    }
}