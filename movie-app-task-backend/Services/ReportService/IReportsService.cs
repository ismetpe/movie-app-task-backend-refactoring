using movie_app_task_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace movie_app_task_backend.Services.ReportService
{
    public interface IReportsService
    {
        Task<List<MostRatedMoviesReport>> MostRatedMoviesReport();
        Task<List<MostScreenedMoviesReport>> MostScreenedMoviesReport(DateTime start,DateTime end);
        Task<List<MovieWithMostSoldTicketsReport>> MoviesWithMostSoldTicketsReport();
    }
}
