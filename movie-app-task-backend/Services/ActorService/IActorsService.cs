using movie_app_task_backend.Dtos.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Services.ActorService
{
   public interface IActorsService
    {
        Task<List<GetActorDto>> GetActors();
 
    }
}
