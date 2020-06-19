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
    public class DiaryController : ControllerBase
    {
        private readonly IDiaryService _diaryService;
        private readonly ISiteService _siteService;
        private readonly ITravelService _travelService;
        private readonly IRouteService _routeService;

        public DiaryController(IDiaryService diaryService, ISiteService siteService, ITravelService travelService, IRouteService routeService)
        {
            this._diaryService = diaryService;
            this._siteService = siteService;
            this._travelService = travelService;
            this._routeService = routeService;
        }

        [HttpPost]
        public ActionResult<Diary> AddDiary(Diary diary)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                var query = _diaryService.GetDiaryByDate(date);
                if(query.Count() == 0)
                {
                    diary.DiaryId = System.Convert.ToInt64(date + "0000");
                }
                else
                {
                    diary.DiaryId = query.First().DiaryId + 1;
                }
                _diaryService.Add(diary);
                return diary;
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        [HttpGet("get")]
        public ActionResult<Diary> GetDairy(long diaryId)
        {
            var diary = _diaryService.GetById(diaryId);
            if(diary != null)
            {
                return diary;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("update")]
        public ActionResult<Diary> UpdateDiary(long diaryId, Diary diary)
        {
            if(!diaryId.Equals(diary.DiaryId))
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

        [HttpDelete("delete")]
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