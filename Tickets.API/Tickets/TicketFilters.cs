using System;

namespace Tickets.API.Tickets
{
    public class TicketFilters
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Status { get; set; }
        public string TicketNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
    }
}