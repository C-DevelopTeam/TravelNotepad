using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Service;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    [Produces("application/xml")]
    public class DiaryController : ControllerBase
    {
        private readonly DiaryService _diaryService;
        private readonly SiteService _siteService;
        private readonly TravelService _travelService;
        private readonly RouteService _routeService;

        public DiaryController(DiaryService diaryService, SiteService siteService, TravelService travelService, RouteService routeService)
        {
            this._diaryService = diaryService;
            this._siteService = siteService;
            this._travelService = travelService;
            this._routeService = routeService;
        }

        [HttpPost("/")]
        public ActionResult<Diary> AddDiary(Diary diary)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                var query = from t in _diaryService.GetDiaries() 
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
                _diaryService.Add(diary);
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
            var diary = _diaryService.GetById(diaryId);
            if(diary != null)
            {
                result.Add(diary);
                if(diary.TravelId != null)
                {
                    var travel = _travelService.GetById(diary.TravelId);
                    if( travel != null)
                    {
                        result.Add(travel);
                        var routes = from r in _routeService.GetRoutes()
                                    where r.TravelId == travel.TravelId
                                    orderby r.StartTime
                                    select r;
                        foreach(Route r in routes)
                        {
                            var startSite = _siteService.GetById(r.StartSiteId);
                            var endSite = _siteService.GetById(r.EndSiteId);
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
                _diaryService.Update(diary);
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
                var diary = _diaryService.GetById(diaryId);
                if(diary != null)
                {
                    _diaryService.Delete(diary);
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