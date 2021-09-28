using System.Collections.Generic;

namespace movie_app_task_backend.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_year { get; set; }
        public string img_url { get; set; }
        public bool isSeries { get; set;}
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Actor> Actors { get; set;} = new List<Actor>();
        public List<Screening> Screenings { get; set;} = new List<Screening>();
    }
}