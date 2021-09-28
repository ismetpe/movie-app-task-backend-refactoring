using System.Collections.Generic;

namespace movie_app_task_backend.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Media> Media { get; set; } = new List<Media>();

    }
}