using System;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Service;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class SiteController : ControllerBase
    {
        private readonly SiteService _siteService;

        public SiteController(SiteService siteService)
        {
            this._siteService = siteService;
        }

        [HttpPost("/")]
        public ActionResult<Site> AddSite(Site site)
        {
            try
            {
                var query = _siteService.GetById(site.SiteId);
                if(query == null)
                {
                    _siteService.Add(site);
                    return Ok();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}