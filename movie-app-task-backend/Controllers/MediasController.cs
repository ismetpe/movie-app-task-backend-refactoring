using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;
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

        [HttpGet("all_movies")]
        public async Task<ActionResult<List<GetMediaDto>>> GetAllMovies()
        {
            return Ok(await _mediaService.GetAllMovies(false));
        }

        [HttpGet("all_series")]
        public async Task<ActionResult<List<GetMediaDto>>> GetAllSeries()
        {
            return Ok(await _mediaService.GetAllSeries(true));
        }

        [HttpGet("ten_movies")]
        public async Task<ActionResult<List<GetMediaDto>>> Get10Movies()
        {
            return Ok(await _mediaService.Get10Movies(false));
        }



        [HttpGet("ten_series")]
        public async Task<ActionResult<List<GetMediaDto>>> Get10Series()
        {
            return Ok(await _mediaService.Get10Series(true));
        }


        [HttpGet("all")]
        public async Task<ActionResult<List<GetMediaDto>>> GetAllMedia()
        {
            return Ok(await _mediaService.GetAllMedia());
        }

      [HttpPost("search")]
        public async Task<ActionResult<List<GetMediaDto>>> Search(string value)
        {
            return Ok(await _mediaService.Search(value));
        }

    }
}