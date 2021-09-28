using movie_app_task_backend.Dtos.Screening;
using movie_app_task_backend.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Services.ScreeningsService
{
   public interface IScreeningsService
    {
        Task<List<GetScreeningDto>> GetScreenings();
        Task<int> BuyTickets(int UserID, int ScreeningID, int NumberOfTickets, DateTime DateOfBuying);
    }
}
