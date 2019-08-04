using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SC.BL.Domain;
using SC.UI.CA;

namespace SC.UI.Web.MVC.Hubs
{
    public class GeneralHub : Hub
    {
        public async Task ServerSendUpdate()
        {
            await Clients.All.SendAsync("ClientReceiveUpdate", CountTickets());
        }

        private List<int> CountTickets()
        {
            NamedRestClient _namedRestClient = new NamedRestClient();
            return _namedRestClient.CountTickets().Result;
        }
    }
}