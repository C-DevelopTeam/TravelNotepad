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
        private readonly ISiteService _siteService;

        public SiteController(ISiteService siteService)
        {
            this._siteService = siteService;
        }

        [HttpPost]
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

        [HttpGet("get")]
        public ActionResult<Site> GetSite(string siteId)
        {
            try
            {
                var site = _siteService.GetById(siteId);
                if(site == null)
                {
                    return NotFound();
                }
                return site;
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }
    }
}