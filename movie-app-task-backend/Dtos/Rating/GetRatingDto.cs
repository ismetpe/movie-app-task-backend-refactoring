using movie_app_task_backend.Models;

namespace movie_app_task_backend.Dtos.Rating
{
    public class GetRatingDto
    {
        public int Id { get; set; }
        public float Rating_value { get; set; }
        public int MediaId { get; set; }
    }
}