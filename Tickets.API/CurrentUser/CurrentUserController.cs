using Microsoft.AspNetCore.Mvc;

namespace Tickets.API.CurrentUser
{
    [ApiController]
    [Route("current-user")]
    public class CurrentUserController : ControllerBase
    {
        [HttpPut("status")]
        public void UpdateStatus()
        {
        }
    }
}