using System;
using Microsoft.AspNetCore.Mvc;

namespace Tickets.API.Contacts
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        [HttpPost]
        public void CreateContact()
        {
        }
        
        [HttpPut("{contactId}/status")]
        public void UpdateStatus(Guid contactId)
        {
        }
    }
}