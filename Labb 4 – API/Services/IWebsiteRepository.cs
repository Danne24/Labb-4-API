using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Services
{
    public interface IWebsiteRepository<T>
    {
        Task<T> Add(T newEntity);
        Task<T> GetSingle(int id);
        Task<T> Update(T Entity);
    }
}
