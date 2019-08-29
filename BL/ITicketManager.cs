using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SC.BL.Domain;
using SC.DAL.EF;

namespace SC.BL
{
  public interface ITicketManager
  {
    IEnumerable<Ticket> GetTickets();
    Ticket GetTicket(int ticketNumber);
    Ticket AddTicket(int accountId, string question);
    Ticket AddTicket(int accountId, string device, string problem);
    void ChangeTicket(Ticket ticket);
    void RemoveTicket(int ticketNumber);

    IEnumerable<TicketResponse> GetTicketResponses(int ticketNumber);
    TicketResponse AddTicketResponse(int ticketNumber, string response, bool isClientResponse);
  }
}
