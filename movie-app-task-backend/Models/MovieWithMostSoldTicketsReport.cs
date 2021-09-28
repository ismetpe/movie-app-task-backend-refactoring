using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Models
{
    public class MovieWithMostSoldTicketsReport
    {
      
        public string Title { get; set; }
        public int ScreeningName { get; set; }
        public int SoldTickets { get; set; }
    }
}
