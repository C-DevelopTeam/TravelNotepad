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
    public class DiaryController : ControllerBase
    {
        private readonly TravelContext travelDb;

        public DiaryController(TravelContext context)
        {
            this.travelDb = context;
        }

        [HttpPost("/")]
        public ActionResult<Diary> PostDiary(Diary diary)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                var query = from t in travelDb.Diaries 
                            where t.DiaryId.ToString().StartsWith(date)
                            orderby t.DiaryId
                            select t;
                if(query.Count() == 0)
                {
                    diary.DiaryId = System.Convert.ToInt64(date + "0000");
                }
                else
                {
                    diary.DiaryId = query.First().DiaryId + 1;
                }
                travelDb.Diaries.Add(diary);
                travelDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpGet("/get")]
        public ActionResult<List<Object>> GetDairy(long diaryId)
        {
            List<Object> result = new List<object>();
            var diary = travelDb.Diaries.FirstOrDefault(t => t.DiaryId == diaryId);
            if(diary != null)
            {
                result.Add(diary);
                if(diary.TravelId != null)
                {
                    var travel = travelDb.Travels.FirstOrDefault(t => t.TravelId == diary.TravelId);
                    if( travel != null)
                    {
                        result.Add(travel);
                        var routes = from r in travelDb.Routes
                                    where r.TravelId == travel.TravelId
                                    orderby r.StartTime
                                    select r;
                        foreach(Route r in routes)
                        {
                            var startSite = travelDb.Sites.FirstOrDefault(s => s.SiteId == r.StartSiteId);
                            var endSite = travelDb.Sites.FirstOrDefault(s => s.SiteId == r.EndSiteId);
                            result.Add(r);
                            result.Add(startSite);
                            result.Add(endSite);
                        }
                    }
                }
                return result;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("/update")]
        public ActionResult<Diary> UpdateDiary(long dairyId, Diary diary)
        {
            if(dairyId != diary.DiaryId)
            {
                return BadRequest("The diary cannot be modified.");
            }
            try
            {
                travelDb.Entry(diary).State = EntityState.Modified;
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
        public ActionResult DeleteDiary(long diaryId)
        {
            try
            {
                var diary = travelDb.Diaries.FirstOrDefault(t => t.DiaryId == diaryId);
                if(diary != null)
                {
                    travelDb.Remove(diary);
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