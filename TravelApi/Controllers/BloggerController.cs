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
    public class BloggerController : ControllerBase
    {
        private readonly IDiaryService _diaryService;

        public BloggerController(IDiaryService diaryService)
        {
            this._diaryService = diaryService;
        }

        //获取分享动态
        [HttpGet("get")]
        public ActionResult<List<Diary>> GetBlogShared()
        {
            IQueryable<Diary> query = _diaryService.GetByShare();
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        [HttpGet("get/user")]
        public ActionResult<List<Diary>> GetBlogSharedByUid(int uid)
        {
            IQueryable<Diary> query = _diaryService.GetShareByUid(uid);
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        [HttpGet("get/userall")]
        public ActionResult<List<Diary>> GetBlogByUid(int uid)
        {
            IQueryable<Diary> query = _diaryService.GetDiaryByUid(uid);
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }
    }
}
