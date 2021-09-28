using movie_app_task_backend.Models;
using System.Threading.Tasks;

namespace movie_app_task_backend.Services.UserService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<int>> Login(string username, string password);
        Task<bool> UserExists(string username);
     
    }
}