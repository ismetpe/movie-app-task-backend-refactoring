using System.Threading.Tasks;
using movie_app_task_backend.Dtos.Rating;

namespace movie_app_task_backend.Services.RatingService
{
    public interface IRatingService
    {
        Task<int> AddRating(float rating, int MediaId);
    }
}