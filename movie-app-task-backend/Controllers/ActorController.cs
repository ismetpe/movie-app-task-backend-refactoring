using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;
using movie_app_task_backend.Services.ActorService;

namespace movie_app_task_backend.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly IActorsService _actorsService;
        public ActorController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetActors(){
               return Ok(await _actorsService.GetActors());
        }

    }
}