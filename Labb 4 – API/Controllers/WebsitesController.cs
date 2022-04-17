using Labb_4___API.Models;
using Labb_4___API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsitesController : ControllerBase
    {
        private IWebsiteRepository<Website> _websiteRepo;

        public WebsitesController(IWebsiteRepository<Website> websiteRepo)
        {
            this._websiteRepo = websiteRepo;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Website>> GetWebsite(int id)
        {
            try
            {
                var result = await this._websiteRepo.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, " Can't Get data from database...");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Website>> CreateNewWebsiteLink(Website newWebsiteLink)
        {
            try
            {
                if (newWebsiteLink == null)
                {
                    return BadRequest();
                }
                var createdWebsiteLink = await this._websiteRepo.Add(newWebsiteLink);

                return CreatedAtAction(nameof(GetWebsite), new { id = createdWebsiteLink.WebsiteID }, createdWebsiteLink);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Website>> UpdateWebsite(int id, Website ws)
        {
            try
            {
                if (id != ws.WebsiteID)
                {
                    return BadRequest("A Website with that ID does not exist!");
                }
                var websiteToUpdate = await this._websiteRepo.GetSingle(id);
                
                if (websiteToUpdate == null)
                {
                    return NotFound($"A Website with the ID {id} was not found!");
                }
                return await this._websiteRepo.Update(ws);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error; could not update data from database...");
            }
        }
    }
}
