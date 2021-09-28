  
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Services.UserService
{
    public class AuthService : IAuthService
    {
                private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public AuthService(DataContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;

        }

        public async Task<ServiceResponse<int>> Login(string username, string password)
        {
            var response = new ServiceResponse<int>();
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username.ToLower().Equals(username.ToLower()));
            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found.";
            }
            else if (password !=  user.Password)
            {
                response.Success = false;
                response.Message = "Wrong password.";
            }
            else
            {
                response.Data = user.Id;
            }

            return response;
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            if (await UserExists(user.Username))
            {
                response.Success = false;
                response.Message = "User already exists.";
                return response;
            }



            user.Password = password;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            response.Data = user.Id;
            return response;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.Username.ToLower().Equals(username.ToLower())))
            {
                return true;
            }
            return false;
        }


    }
}