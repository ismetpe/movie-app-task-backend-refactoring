using Microsoft.AspNetCore.Mvc;
using movie_app_task_backend.Dtos.PurchasedTickets;
using movie_app_task_backend.Services.ScreeningsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Controllers
{
    [ApiController]
    [Route("apiscreenings")]
    public class ScreeningsController : ControllerBase
    {
        private readonly IScreeningsService _screeningsService;

        public ScreeningsController(IScreeningsService screeningsService)
        {
            _screeningsService = screeningsService;
        }
        [HttpPost("buy_ticket")]
        public async Task<ActionResult<int>> BuyTicket(int UserID, int ScreeningID, int NumberOfTickets, DateTime DateOfBuying)
        {
            return Ok(await _screeningsService.BuyTickets( UserID,  ScreeningID,  NumberOfTickets,  DateOfBuying));
        }
    }
}
