using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Castle.Core.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SC.BL.Domain;

namespace SC.UI.CA
{
    public class RestClient
    {
        private const string baseUri = "https://localhost:5001/api/";

        private HttpClient GetNewHttpClient()
        {
            HttpClientHandler httpHandler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (request, certificate, chain, sslPolicyErrors) => true
            };
            return new HttpClient(httpHandler);
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            IEnumerable<Ticket> tickets = null;
            var request = new HttpRequestMessage(HttpMethod.Get, 
                 baseUri + "Tickets");
            /*
            var client = _clientFactory.CreateClient("rest");
            var response = await client.SendAsync(request);
            */
            var client = GetNewHttpClient();
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

        public async Task<Ticket> GetTicket(int ticketNumber)
        {
            Ticket ticket = null;
            var request = new HttpRequestMessage(HttpMethod.Get, 
                baseUri + "Tickets/" + ticketNumber);
            var client = GetNewHttpClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                ticket = JsonConvert.DeserializeObject<Ticket>(result);
            }
            
            return ticket;
        }

        public async Task<IEnumerable<TicketResponse>> GetTicketResponses(int ticketNumber)
        {
            IEnumerable<TicketResponse> responses = null;
            var request = new HttpRequestMessage(HttpMethod.Get,
                baseUri + "TicketResponses?ticketNumber=" + ticketNumber);
            var client = GetNewHttpClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string responseContentAsString = response.Content.ReadAsStringAsync().Result;
                //Body-string (in json-formaat) deserializeren (omzetten) naar een verzameling van TicketResponse-objecten
                responses = JsonConvert.DeserializeObject<List<TicketResponse>>(responseContentAsString);
            }
            else
            {
                throw new Exception(response.StatusCode + " " + response.ReasonPhrase);
            }

            return responses;
        }

        public async Task<Ticket> PostTicket(int accountNumber, string problem)
        {
            Ticket ticket = null;
            var request = new HttpRequestMessage(HttpMethod.Post, 
                baseUri + "Tickets");
            var client = GetNewHttpClient();
            object data = new {TicketNumber = accountNumber, Text = problem};
            string dataAsJsonString = JsonConvert.SerializeObject(data);
            request.Content = new StringContent(dataAsJsonString, System.Text.Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string responseContentAsString = response.Content.ReadAsStringAsync().Result;
                ticket = JsonConvert.DeserializeObject<Ticket>(responseContentAsString);
            }
            else
            {
                throw new Exception(response.StatusCode + " " + response.ReasonPhrase);
            }

            return ticket;
        }
        
        public async Task<Ticket> PostHardwareTicket(int accountNumber, string device, string problem)
        {
            Ticket ticket = null;
            var request = new HttpRequestMessage(HttpMethod.Post, 
                baseUri + "Tickets");
            var client = GetNewHttpClient();
            object data = new {TicketNumber = accountNumber, DeviceName = device, Text = problem};
            string dataAsJsonString = JsonConvert.SerializeObject(data);
            request.Content = new StringContent(dataAsJsonString, System.Text.Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string responseContentAsString = response.Content.ReadAsStringAsync().Result;
                ticket = JsonConvert.DeserializeObject<Ticket>(responseContentAsString);
            }
            else
            {
                throw new Exception(response.StatusCode + " " + response.ReasonPhrase);
            }

            return ticket;
        }
        
        public async Task<TicketResponse> PostTicketResponse(int ticketNumber, string response, bool isClientResponse)
        {
            TicketResponse tr = null;
            var request = new HttpRequestMessage(HttpMethod.Post, 
                baseUri + "TicketResponses");
            var client = GetNewHttpClient();
            //Request data toevoegen aan body, via anonymous object dat je serialiseert naar json-formaat
            object data = new { TicketNumber = ticketNumber, ResponseText = response, IsClientResponse = isClientResponse };
            string dataAsJsonString = JsonConvert.SerializeObject(data);
            request.Content = new StringContent(dataAsJsonString, System.Text.Encoding.UTF8, "application/json");
            //Verwachte content-type van de response meegeven
            var httpResponse = await client.SendAsync(request);
            if (httpResponse.IsSuccessStatusCode)
            {
                //Body van de response uitlezen als een string
                string responseContentAsString = httpResponse.Content.ReadAsStringAsync().Result;
                //Body-string (in json-formaat) deserializeren (omzetten) naar een TicketResponse-object
                tr = JsonConvert.DeserializeObject<TicketResponse>(responseContentAsString);
            }
            else
            {
                throw new Exception(httpResponse.StatusCode + " " + httpResponse.ReasonPhrase);
            }

            return tr;
        }

        public async Task PutTicket(int id, int accountId, string problem)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, baseUri + "Tickets/" + id);
            var client = GetNewHttpClient();
            object data = new {AccountId = accountId, Text = problem};
            string dataAsJsonString = JsonConvert.SerializeObject(data);
            request.Content = new StringContent(dataAsJsonString, System.Text.Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
            }
            else
            {
                throw new Exception(response.StatusCode + " " + response.ReasonPhrase);
            }
        }

        public async Task PatchTicket(int id, int accountId, string problem)
        {
            var request = new HttpRequestMessage(HttpMethod.Patch, baseUri + "Tickets/" + id);
            var client = GetNewHttpClient();
            object data = new {AccountId = accountId, Text = problem};
            string dataAsJsonString = JsonConvert.SerializeObject(data);
            request.Content = new StringContent(dataAsJsonString, System.Text.Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
            }
            else
            {
                throw new Exception(response.StatusCode + " " + response.ReasonPhrase);
            }
        }

        public async Task DeleteTicket(int ticketNumber)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete,
                baseUri + "Tickets/" + ticketNumber);
            var client = GetNewHttpClient();
            var response = await client.SendAsync(request);
        }

        public async Task<List<int>> CountTickets()
        {
            IEnumerable<Ticket> tickets;
            List<int> list = new List<int>();
            int countClosed = 0;
            var request = new HttpRequestMessage(HttpMethod.Get, 
                baseUri + "Tickets");
            var client = GetNewHttpClient();
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
            foreach (Ticket ticket in tickets)
            {
                if (ticket.State.Equals(TicketState.Closed))
                {
                    countClosed++;
                }
            }
            list.Add(tickets.Count());
            list.Add(countClosed);
            list.Add(tickets.Count() -countClosed);

            return list;
        }
    }
    
}