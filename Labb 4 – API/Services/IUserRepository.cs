using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Services
{
    public interface IUserRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetSingle(int id);
    }
}
