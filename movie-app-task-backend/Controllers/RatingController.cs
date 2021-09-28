using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos.Rating;
using movie_app_task_backend.Models;
using movie_app_task_backend.Services.RatingService;

namespace movie_app_task_backend.Controllers
{
    
    [ApiController]
    [Route("rating")]
    public class RatingController : ControllerBase
    {        private readonly IRatingsService _ratingService;

        public RatingController(IRatingsService ratingService) 
        {

            _ratingService = ratingService;

        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddRating(AddRatingDto addRating)
        {
            var response = await _ratingService.AddRating(addRating.Rating_value, addRating.MediaId);
            
            return Ok(response);
        }
    }
}