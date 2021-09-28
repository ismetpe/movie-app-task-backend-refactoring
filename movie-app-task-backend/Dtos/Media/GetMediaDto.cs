using System.Collections.Generic;
using movie_app_task_backend.Dtos.Actor;
using movie_app_task_backend.Dtos.Rating;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Dtos
{
    public class GetMediaDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_year { get; set; }
        public string img_url { get; set; }
        public bool isSeries { get; set;}
        public List<GetRatingDto> Ratings { get; set; } = new List<GetRatingDto>();
        public List<GetActorDto> Actors { get; set;} = new List<GetActorDto>();
    }
}