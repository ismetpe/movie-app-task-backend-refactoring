using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Services.ReportService
{
    public class ReportService : IReportService
    {
        private readonly DataContext _context;

        public ReportService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<MostRatedMoviesReport>> MostRatedMoviesReport()
        {
           

           var result = await _context.MostRatedMoviesReports.FromSqlRaw("EXEC [dbo].[GetTopTenMoviesWithMostRating];").ToListAsync();
         

            return result;

        }

        public async Task<List<MostScreenedMoviesReport>> MostScreenedMoviesReport(DateTime start, DateTime end)
        {
            var result = await _context.MoviesWithMostScreeningsReports.FromSqlRaw("EXEC [dbo].[GetTopTenMoviesWithMostScreening] {0}, {1};", start, end).ToListAsync();

            return result;

        }

        public async Task<List<MovieWithMostSoldTicketsReport>> MoviesWithMostSoldTicketsReport()
        {
            var result = await _context.MoviesWithMostSoldTicketsReports.FromSqlRaw("EXEC [dbo].[GetMoviesWithMostSoldTicketsWithoutRating]")
                                                                      .ToListAsync();

            return result;
        }
    }
}
