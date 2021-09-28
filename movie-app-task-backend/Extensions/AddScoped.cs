using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using movie_app_task_backend.Services.MediaService;
using movie_app_task_backend.Services.RatingService;
using movie_app_task_backend.Services.ReportService;
using movie_app_task_backend.Services.ScreeningsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Extensions
{
    public class AddScoped
    {
        public static void AddScopedConfig(ref IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IMediaService, MediaService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IScreeningsService, ScreeningsService>();
        }
    }
}
