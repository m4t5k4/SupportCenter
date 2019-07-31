using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using SC.BL;
using SC.BL.Domain;
using SC.UI.CA.ExtensionMethods;

namespace SC.UI.CA
{
    class Program
    {
        private static bool quit = false;
        private static /*readonly*/ ITicketManager mgr = new TicketManager();
        private static readonly Service srv = new Service();
        private static RestClient rClient = new RestClient();
        private static NamedRestClient _namedRestClient = new NamedRestClient();
        //private static readonly IHttpClientFactory _clientFactory;

        static void Main(string[] args)
        {
            while (!quit)
                ShowMenu();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("=== HELPDESK - SUPPORT CENTER ===");
            Console.WriteLine("=================================");
            Console.WriteLine("1) Toon alle tickets");
            Console.WriteLine("2) Toon details van een ticket");
            Console.WriteLine("3) Toon de antwoorden van een ticket");
            Console.WriteLine("4) Maak een nieuw ticket");
            Console.WriteLine("5) Geef een antwoord op een ticket");
            Console.WriteLine("0) Afsluiten.");
            try
            {
                DetectMenuAction();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Er heeft zich een onverwachte fout voorgedaan!");
                Console.WriteLine(e);
            }
        }

        private static void DetectMenuAction()
        {
            bool inValidAction = false;
            do
            {
                inValidAction = false;
                Console.Write("Keuze: ");
                string input = Console.ReadLine();
                int action;
                if (Int32.TryParse(input, out action))
                {
                    mgr = new TicketManager();
                    switch (action)
                    {
                        case 1:
                            PrintAllTickets(); break;
                        case 2:
                            ActionShowTicketDetails(); break;
                        case 3:
                            ActionShowTicketResponses(); break;
                        case 4:
                            ActionCreateTicket(); break;
                        case 5:
                            ActionAddResponseToTicket(); break;
                        case 0:
                            quit = true;
                            return;
                        default:
                            Console.WriteLine("Geen geldige keuze!");
                            inValidAction = true;
                            break;
                    }
                }
            } while (inValidAction);
        }

        private static void PrintAllTickets()
        {

            /*via mgr
            foreach (var t in mgr.GetTickets())
            {
                Console.WriteLine(t.GetInfo());
            }*/

            //via rest
            foreach (var ticket in _namedRestClient.GetAllTickets().Result)
            {
                Console.WriteLine(ticket.GetInfo());
            }
        }

        private static void ActionShowTicketDetails()
        {
            
            Console.Write("Ticketnummer: ");
            int input = Int32.Parse(Console.ReadLine());

            /*
            Ticket t = mgr.GetTicket(input);
            */
            
            //via rest
            Ticket t = _namedRestClient.GetTicket(input).Result;
            
            PrintTicketDetails(t);


        }

        private static void PrintTicketDetails(Ticket ticket)
        {
            Console.WriteLine("{0,-15}: {1}", "Ticket", ticket.TicketNumber);
            Console.WriteLine("{0,-15}: {1}", "Gebruiker", ticket.AccountId);
            Console.WriteLine("{0,-15}: {1}", "Datum", ticket.DateOpened.ToString("dd/MM/yyyy"));
            Console.WriteLine("{0,-15}: {1}", "Status", ticket.State);

            if (ticket is HardwareTicket)
                Console.WriteLine("{0,-15}: {1}", "Toestel", ((HardwareTicket)ticket).DeviceName);

            Console.WriteLine("{0,-15}: {1}", "Vraag/probleem", ticket.Text);
        }

        private static void ActionShowTicketResponses()
        {
            Console.Write("Ticketnummer: ");
            int input = Int32.Parse(Console.ReadLine());

            //via mgr
            //IEnumerable<TicketResponse> responses = mgr.GetTicketResponses(input);
            // via Web API-service
            //IEnumerable<TicketResponse> responses = srv.GetTicketResponses(input);
            //via rest
            IEnumerable<TicketResponse> responses = _namedRestClient.GetTicketResponses(input).Result;

            if (responses != null)
            {
                PrintTicketResponses(responses);
            }
        }

        private static void PrintTicketResponses(IEnumerable<TicketResponse> responses)
        {
            foreach (var r in responses)
                Console.WriteLine(r.GetInfo());
        }

        private static void ActionCreateTicket()
        {
            
            int accountNumber = 0;
            string problem = "";
            string device = "";

            Console.Write("Is het een hardware probleem (j/n)? ");
            bool isHardwareProblem = (Console.ReadLine().ToLower() == "j");
            if (isHardwareProblem)
            {
                Console.Write("Naam van het toestel: ");
                device = Console.ReadLine();
            }

            Console.Write("Gebruikersnummer: ");
            accountNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Probleem: ");
            problem = Console.ReadLine();

            /*
            if (!isHardwareProblem)
                mgr.AddTicket(accountNumber, problem);
            else
                mgr.AddTicket(accountNumber, device, problem);
            */

            if (!isHardwareProblem)
            {
                _namedRestClient.PostHardwareTicket(accountNumber, device, problem);
            }
            else
            {
                _namedRestClient.PostTicket(accountNumber, problem);
            }
        }

        private static async void ActionAddResponseToTicket()
        {
            Console.Write("Ticketnummer: ");
            int ticketNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Antwoord: ");
            string response = Console.ReadLine();

            //via mgr
            //mgr.AddTicketResponse(ticketNumber, response, false);
            // via WebAPI-service
            //srv.AddTicketResponse(ticketNumber, response, false);
            //via rest
            await _namedRestClient.PostTicketResponse(ticketNumber, response, false);
        }
    }
}