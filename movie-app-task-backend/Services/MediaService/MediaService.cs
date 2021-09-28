using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos;
using System.Linq;

using System;
using System.Text.RegularExpressions;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Services.MediaService
{
    public class MediaService : IMediaService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public MediaService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<GetMediaDto>> Get10Movies(bool isSeries)
        {
            var allSeriesdto= await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .Take(10)
            .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();


            /*.Select(x => _mapper.Map<GetMediaDto>(x))
            .ToList())
            .OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            result = allSeriesdto;
            return result;*/

            return allSeriesdto;
        }

        public async Task<List<GetMediaDto>> Get10Series(bool isSeries)
        {
          var result = new List<GetMediaDto>();


            var allSeriesdto= await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .Take(10)
            .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();


            /*.Select(x => _mapper.Map<GetMediaDto>(x))
            .ToList())
            .OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            result = allSeriesdto;
            return result;*/

            return allSeriesdto;
        }

        public async Task<List<GetMediaDto>> GetAllMovies(bool isSeries)
        {
            var allMoviesdto= await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();
            return allMoviesdto;
        }

        public async Task<List<GetMediaDto>> GetAllSeries(bool isSeries)
        {
 

            var allSeriesdto= await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Where(x => x.isSeries == isSeries)
            .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();


            /*.Select(x => _mapper.Map<GetMediaDto>(x))
            .ToList())
            .OrderByDescending(x => x.Ratings.Select(x => x.Rating_value).Average()).ToList();
            result = allSeriesdto;
            return result;*/

            return allSeriesdto;
        }

  
        
        public async Task<List<GetMediaDto>> GetAllMedia()
        {
           var allMoviesdto= await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery()
            .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();
            return allMoviesdto;
        }

    public async Task<List<GetMediaDto>> Search(string value)
        {
//throw new NotSupportedException();
var result = new List<GetMediaDto>();
var splitedWords = Regex.Split(value, @"\s+").ToList();

    var media= await _context.Medias
            .Include(x => x.Ratings)
            .AsSplitQuery()
            .Include(x => x.Actors)
            .AsSplitQuery().Where(s => s.Title.ToUpper().Contains(value.ToUpper())  ||  s.Description.ToUpper().Contains(value.ToUpper()) ).Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();

 


result = media;
    return result;

        }
    }
}