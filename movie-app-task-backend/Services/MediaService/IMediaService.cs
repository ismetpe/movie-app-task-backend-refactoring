using System.Collections.Generic;
using System.Threading.Tasks;
using movie_app_task_backend.Dtos;
using movie_app_task_backend.Dtos.Request;

namespace movie_app_task_backend.Services.MediaService
{
    public interface IMediaService
    {
         Task<List<GetMediaDto>> GetMedia(RequestDto request);
    }
}