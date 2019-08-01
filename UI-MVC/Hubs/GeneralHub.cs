using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SC.UI.Web.MVC.Hubs
{
    public class GeneralHub : Hub
    {
        public async Task SendUpdate()
        {
            await Clients.All.SendAsync("ReceiveUpdate");
        }
    }
}