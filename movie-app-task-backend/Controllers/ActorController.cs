using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly DataContext _contex;
        public ActorController(DataContext contex)
        {
             _contex = contex;
           
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetActors(){
            return  await _contex.Actors.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Actor>> GetActor(int id){
             return await _contex.Actors.FindAsync(id);
        }
    }
}