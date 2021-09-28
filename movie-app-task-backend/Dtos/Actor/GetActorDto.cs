using System.Collections.Generic;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Dtos.Actor
{
    public class GetActorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}