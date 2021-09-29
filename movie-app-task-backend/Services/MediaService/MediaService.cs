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
using movie_app_task_backend.Dtos.Request;
using Microsoft.AspNetCore.Mvc;

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
        private async Task<List<GetMediaDto>> SearchFilter(string value)
        {
            //throw new NotSupportedException();
            return await _context.Medias
                          .Include(x => x.Ratings)
                          .AsSplitQuery()
                          .Include(x => x.Actors)
                          .AsSplitQuery().Where(s => s.Title.ToUpper().Contains(value.ToUpper()) || s.Description.ToUpper().Contains(value.ToUpper())).Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();


        }
        private async Task<List<GetMediaDto>> TypeFilter(MediaType? type, int pagination)
        {
         
           
                return await _context.Medias
                                      .Include(x => x.Ratings)
                                      .AsSplitQuery()
                                      .Include(x => x.Actors)
                                      .AsSplitQuery()
                                      .Where(x => x.MediaType == type)
                                      .Take(pagination)
                                      .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();
      
            
        }
        public async Task<List<GetMediaDto>> GetMedia(RequestDto request)
        {

            if (!string.IsNullOrEmpty(request.SearchTerm))
            {
                return await SearchFilter(request.SearchTerm);
            }
            if (request.Type != null)
            {
                return await TypeFilter(request.Type,request.Pagination);
            }
            if(request.GetMediaId != null)
            {
                return await _context.Medias
                                      .Include(x => x.Ratings)
                                      .AsSplitQuery()
                                      .Include(x => x.Actors)
                                      .AsSplitQuery()
                                      .Where(x => x.Id == request.GetMediaId)
                                      .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();
            }

                return await _context.Medias
                                           .Include(x => x.Ratings)
                                           .AsSplitQuery()
                                           .Include(x => x.Actors)
                                           .AsSplitQuery()
                                           .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();
        }
    }
}