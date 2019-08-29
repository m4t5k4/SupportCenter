using System.Linq;
using System.Net;
using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using SC.BL;
using SC.BL.Domain;
using SC.UI.Web.MVC.Models;

namespace SC.UI.Web.MVC.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private ITicketManager mgr = new TicketManager();
        
        // GET: api/Tickets
        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var tickets = mgr.GetTickets();
            
            if (tickets == null || !EnumerableExtensions.Any(tickets))
                return NoContent(); //of: StatusCode(StatusCodes.Status204NoContent);

            return Ok(tickets);
        }
        
        //GET: api/Tickets/5
        [HttpGet("{id}")]
        public IActionResult GetTicket(int id)
        {
            var ticket = mgr.GetTicket(id);

            if (ticket == null)
            {
                return NoContent();
            }

            return Ok(ticket);
        }
        
        //POST: api/Tickets
        [HttpPost]
        public IActionResult PostTicket(NewTicketDTO response)
        {
            Ticket createdTicket = mgr.AddTicket(response.AccountId, response.Text);

            if (createdTicket == null)
            {
                return BadRequest("Er is iets misgelopen tijdens het toevoegen");
            }

            TicketDTO responseData = new TicketDTO()
            {
                TicketNumber = createdTicket.TicketNumber,
                AccountId = createdTicket.AccountId,
                Text = createdTicket.Text
            };

            return CreatedAtAction("GetTicket", new {ticketNumber = responseData.TicketNumber});
        }
        
        //POST: api/Tickets/HardwareTicket
        [HttpPost]
        [Route("HardwareTicket")]
        public IActionResult PostHardwareTicket(NewHardwareTicketDTO response)
        {
            HardwareTicket createdTicket =  (HardwareTicket) mgr.AddTicket(response.AccountId, response.DeviceName, response.Text);

            if (createdTicket == null)
            {
                return BadRequest("Er is iets misgelopen tijdens het toevoegen");
            }

            HardwareTicketDTO responseData = new HardwareTicketDTO()
            {
                TicketNumber = createdTicket.TicketNumber,
                AccountId = createdTicket.AccountId,
                Text = createdTicket.Text,
                DeviceName = createdTicket.DeviceName
            };

            return CreatedAtAction("GetTicket", new {ticketNumber = responseData.TicketNumber});
        }

        // PUT: api/Tickets/5/State/Closed
        [HttpPut("{id}/State/Closed")]
        public IActionResult PutTicketStateToClosed(int id)
        {
            Ticket ticket = mgr.GetTicket(id);

            if (ticket == null)
                return NotFound();

            ticket.State = TicketState.Closed;
            mgr.ChangeTicket(ticket);
            
            return NoContent();
        }
        
        //public IActionResult
        [HttpPut("{id}")]
        public IActionResult PutTicket(int id, [FromBody] TicketDTO data)
        {
            Ticket t = mgr.GetTicket(id);
            t.AccountId = data.AccountId;
            t.Text = data.Text;
            mgr.ChangeTicket(t);
            return Ok();

        }
        
        [HttpPatch("{id}")]
        public IActionResult PatchTicket(int id, [FromBody] TicketDTO data)
        {
            Ticket t = mgr.GetTicket(id);
            if (!data.AccountId.Equals(0))
            {
                t.AccountId = data.AccountId;
            }

            if (!data.Text.IsNullOrEmpty())
            {
                t.Text = data.Text;
            }
            mgr.ChangeTicket(t);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id)
        {
            mgr.RemoveTicket(id);
            return NoContent();
        }

    }
}