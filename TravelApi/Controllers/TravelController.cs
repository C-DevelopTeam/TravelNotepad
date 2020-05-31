using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TravelApi.Dao;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    [Produces("application/xml")]
    public class TravelController : ControllerBase
    {
        private readonly TravelContext travelDb;

        public TravelController(TravelContext context)
        {
            this.travelDb = context;
        }

        // POST: api/travel
        [HttpPost("/")]
        public ActionResult<Travel> PostTravel(int uid, Travel travel)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                var query = from t in travelDb.Travels 
                            where t.TravelId.ToString().StartsWith(date)
                            orderby t.TravelId
                            select t;
                if(query.Count() == 0)
                {
                    travel.TravelId = System.Convert.ToInt64(date + "0000");
                }
                else
                {
                    travel.TravelId = query.First().TravelId + 1;
                }
                travel.Uid = uid;
                travelDb.Travels.Add(travel);
                travelDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpGet("/get")]
        public ActionResult<List<Travel>> GetTravel(int uid)
        {
            var query = travelDb.Travels.Where(t => t.Uid == uid);
            return query.ToList();
        }

        [HttpPut("/update")]
        public ActionResult<Travel> UpdateTravel(long travelid, Travel travel)
        {
            if(travelid != travel.TravelId)
            {
                return BadRequest("The travel cannot be modified.");
            }
            try
            {
                travelDb.Entry(travel).State = EntityState.Modified;
                travelDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpDelete("/delete")]
        public ActionResult DeleteTravel(long travelid)
        {
            try
            {
                var travel = travelDb.Travels.FirstOrDefault(t => t.TravelId == travelid);
                if(travel != null)
                {
                    travelDb.Remove(travel);
                    travelDb.SaveChanges();
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