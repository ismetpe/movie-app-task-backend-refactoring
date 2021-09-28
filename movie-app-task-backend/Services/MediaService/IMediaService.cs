using System.Collections.Generic;
using System.Threading.Tasks;
using movie_app_task_backend.Dtos;

namespace movie_app_task_backend.Services.MediaService
{
    public interface IMediaService
    {
        Task<List<GetMediaDto>> GetAllMovies(bool isSeries);
        Task<List<GetMediaDto>> GetAllSeries(bool isSeries);

        Task<List<GetMediaDto>> Get10Series(bool isSeries);

        Task<List<GetMediaDto>> Get10Movies(bool isSeries);

         Task<List<GetMediaDto>> Search(string value);
         Task<List<GetMediaDto>> GetAllMedia();
    }
}