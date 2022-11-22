using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netIdentitys.Entities;
using Microsoft.AspNetCore.SignalR;


namespace Asp.netIdentitys.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(Messages message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
