namespace movie_app_task_backend.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

    }
}