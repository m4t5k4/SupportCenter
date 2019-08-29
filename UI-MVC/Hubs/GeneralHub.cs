using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SC.BL.Domain;
using SC.UI.CA;
using RestClient = SC.UI.CA.RestClient;

namespace SC.UI.Web.MVC.Hubs
{
    public class GeneralHub : Hub
    {
        public async Task ServerSendUpdate()
        {
            List<int> list = CountTickets();
            await Clients.All.SendAsync("ClientReceiveUpdate", list);
        }

        private List<int> CountTickets()
        {
            RestClient restClient = new RestClient();
            return restClient.CountTickets().Result;
        }
    }
}