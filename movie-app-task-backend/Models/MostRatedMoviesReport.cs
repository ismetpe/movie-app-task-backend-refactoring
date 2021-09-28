using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Models
{
    public class MostRatedMoviesReport
    {
        public string Title { get; set; }
        public int NumberOfRatings { get; set; }
        public double MovieRating { get; set; }
    }
}
