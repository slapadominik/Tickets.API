using System;
using Microsoft.AspNetCore.Mvc;

namespace Tickets.API.ActiveCall
{
    [ApiController]
    [Route("[controller]")]
    public class ActiveCallController : ControllerBase
    {
        [HttpPut("{callId}")]
        public void CreateCall(Guid callId)
        {
        }
        
        [HttpPut("{callId}/status")]
        public void UpdateStatus(Guid callId)
        {
        }
    }
}