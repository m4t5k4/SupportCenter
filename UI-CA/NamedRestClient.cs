using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SC.BL.Domain;

namespace SC.UI.CA
{
    public class NamedRestClient
    {
        private readonly IHttpClientFactory _clientFactory;
        
        public NamedRestClient(/*IHttpClientFactory clientFactory*/)
        {
            //_clientFactory = clientFactory;
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            IEnumerable<Ticket> tickets = null;
            var request = new HttpRequestMessage(HttpMethod.Get, 
                "Tickets/");
            var client = _clientFactory.CreateClient("rest");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                tickets = JsonConvert.DeserializeObject<IEnumerable<Ticket>>(result);
            }
            else
            {
                throw new Exception(response.StatusCode + " " + response.ReasonPhrase);
            }

            return tickets;
        }
    }
}