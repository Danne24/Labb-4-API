using Labb_4___API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Services
{
    public class UserRepo : IUserRepository<User>
    {
        private Labb4DbContext _labb4DbContext;

        public UserRepo(Labb4DbContext labb4DbContext)
        {
            this._labb4DbContext = labb4DbContext;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await this._labb4DbContext.Users.ToListAsync();
        }

        public async Task<User> GetSingle(int id)
        {
            return await this._labb4DbContext.Users.Include(u => u.Websites).ThenInclude(u => u.Hobby).FirstOrDefaultAsync(u => u.UserID == id);
        }
    }
}
