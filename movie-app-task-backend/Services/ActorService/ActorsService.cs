using AutoMapper;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Services.ActorService
{
    public class ActorsService : IActorsService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ActorsService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<GetActorDto>> GetActors()
        {
            return await _context.Actors.Select(x => _mapper.Map<GetActorDto>(x)).ToListAsync();
        }
    }
}
