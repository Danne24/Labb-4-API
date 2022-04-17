using Labb_4___API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Services
{
    public class WebsiteRepo : IWebsiteRepository<Website>
    {
        private Labb4DbContext _labb4DbContext;

        public WebsiteRepo(Labb4DbContext labb4DbContext)
        {
            this._labb4DbContext = labb4DbContext;
        }

        public async Task<Website> Add(Website newEntity)
        {
            var result = await this._labb4DbContext.Websites.AddAsync(newEntity);
            await this._labb4DbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Website> GetSingle(int id)
        {
            return await this._labb4DbContext.Websites.FirstOrDefaultAsync(w => w.WebsiteID == id);
        }

        public async Task<Website> Update(Website Entity)
        {
            var result = await this._labb4DbContext.Websites.FirstOrDefaultAsync(w => w.WebsiteID == Entity.WebsiteID);
            if (result != null)
            {
                result.WebsiteID = Entity.WebsiteID;
                result.HobbyID = Entity.HobbyID;
                result.UserID = Entity.UserID;

                await this._labb4DbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
