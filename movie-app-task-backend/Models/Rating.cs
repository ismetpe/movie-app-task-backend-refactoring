

using System;

namespace movie_app_task_backend.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public float Rating_value { get; set; }

        public int MediaId { get; set; }
      
        public Media Media { get; set; }
    }
}