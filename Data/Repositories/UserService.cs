using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorAuthApp.Data.Repositories
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(string username, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }
    }
}
