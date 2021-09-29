using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;
using movie_app_task_backend.Dtos.Request;
using movie_app_task_backend.Models;
using movie_app_task_backend.Services.MediaService;

namespace movie_app_task_backend.Controllers
{
   [ApiController]
    [Route("media")]
    public class VideosController : ControllerBase
    {

        private readonly IMediaService _mediaService;

        public VideosController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        [HttpGet("api/get_media")]
        public async Task<ActionResult<List<GetMediaDto>>> GetAllMovies([FromQuery] RequestDto req)
        {
            return Ok(await _mediaService.GetMedia(req));
        }
    }
}