using System.Collections.Generic;

namespace movie_app_task_backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<PurchasedTicket> PurchasedTickets { get; set; } = new List<PurchasedTicket>();
        
    }
}