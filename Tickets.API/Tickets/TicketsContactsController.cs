using System;
using Microsoft.AspNetCore.Mvc;

namespace Tickets.API.Tickets
{
    [ApiController]
    [Route("tickets/{ticketId}/contacts")]
    public class TicketsContactsController : ControllerBase
    {
        [HttpPut("{contactId}")]
        public void AttachContact(Guid ticketId, Guid contactId)
        {
        }
        
        [HttpDelete("{contactId}")]
        public void DetachContact(Guid ticketId, Guid contactId)
        {
        }
    }
}