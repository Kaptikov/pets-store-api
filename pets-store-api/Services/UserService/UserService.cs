using Microsoft.EntityFrameworkCore;
using pets_store_api.Data;
using pets_store_api.Models;

namespace pets_store_api.Services.UserService
{
    public class UserService : IUserService
    {
        /*private static List<User> users = new List<User>
            {
                new User { Id = 1,
                    Name = "NoName",
                    Email="email@mail.ru",
                    PhoneNumber="79999999999"
                },

                new User { Id = 2,
                    Name = "Ivan",
                    Email="Ivan@mail.ru",
                    PhoneNumber="79999999999"
                }
            };*/
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>?> DeteleUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> GetAllUser()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User?> GetSingleUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return user;

            return user;
        }

        public async Task<List<User>?> UpdateUser(int id, User request)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            user.Name = request.Name;
            user.Email = request.Email;
            user.PhoneNumber = request.PhoneNumber;

            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }
    }
}
