using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Service;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class TravelController : ControllerBase
    {
        private readonly ITravelService _travelService;

        public TravelController(ITravelService travelService)
        {
            this._travelService = travelService;
        }

        // POST: api/travel
        [HttpPost]
        public ActionResult<Travel> AddTravel(Travel travel)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                var query = _travelService.GetTravelByDate(date);
                if(query.Count() == 0)
                {
                    travel.TravelId = System.Convert.ToInt64(date + "0000");
                }
                else
                {
                    travel.TravelId = query.First().TravelId + 1;
                }
                _travelService.Add(travel);
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpGet("get")]
        public ActionResult<List<Travel>> GetTravel(int uid)
        {
            var query = _travelService.GetByUid(uid);
            return query.ToList();
        }

        [HttpPut("update")]
        public ActionResult<Travel> UpdateTravel(long travelId, Travel travel)
        {
            if(travelId != travel.TravelId)
            {
                return BadRequest("The travel cannot be modified.");
            }
            try
            {
                _travelService.Update(travel);
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpDelete("delete")]
        public ActionResult DeleteTravel(long travelId)
        {
            try
            {
                var travel = _travelService.GetById(travelId);
                if(travel != null)
                {
                    _travelService.Delete(travel);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}