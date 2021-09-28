using AutoMapper;
using movie_app_task_backend.Dtos;
using movie_app_task_backend.Dtos.Actor;
using movie_app_task_backend.Dtos.Rating;
using movie_app_task_backend.Dtos.Screening;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
                public AutoMapperProfile()
        {
            CreateMap<Media, GetMediaDto>();
            CreateMap<Rating, GetRatingDto>();
            CreateMap<Actor, GetActorDto>();
            CreateMap<Screening, GetScreeningDto>();
        }
    }
}