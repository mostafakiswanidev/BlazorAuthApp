using System.Threading.Tasks;

namespace BlazorAuthApp.Data.Repositories
{
    public interface IUserService
    {
        Task<User> GetUserAsync(string username, string password);
    }
}
