using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tickets.API.Tickets
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpPost]
        public void CreateTicket()
        {
        }
        
        [HttpPut("{ticketId}/status")]
        public void UpdateStatus(Guid ticketId)
        {
        }
        
        [HttpPost("{ticketId}/emails")]
        public void WriteEmail(Guid ticketId)
        {
        }
        
        [HttpPost("{ticketId}/calls")]
        public void InitateCall(Guid ticketId)
        {
        }

        [HttpPost("{ticketId}/sms")]
        public void WriteSms(Guid ticketId)
        {
        }
        
        [HttpPost("{ticketId}/comments")]
        public void AddComment(Guid ticketId)
        {
        }
        
        [HttpPost("{ticketId}/attachments")]
        public void AddAttachment(Guid ticketId)
        {
        }

        [HttpGet]
        public Task<IEnumerable<TicketSummary>> GetTickets(TicketFilters ticketFilters)
        {
            return null;
        }
        
        [HttpGet("{ticketId}")]
        public Task<TicketDetails> GetTicketDetails(Guid ticketId)
        {
            return null;
        }
    }
    /*/current-user/status PUT

    /tickets POST
    /tickets/{ticketId}/contacts/{contactId} PUT
    /tickets/{ticketId}/contacts/{contactId} DELETE
    /tickets/{id}/status PUT
    /tickets/{id}/emails POST
    /tickets/{id}/calls POST
    /tickets/{id}/smses POST

    /contacts POST
    /contacts/{id}/status PUT

    /calls/{id} PUT
    /calls/{id}/status PUT*/
}