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
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class BloggerController : ControllerBase
    {
        private readonly TravelContext travelDb;

        public BloggerController(TravelContext context)
        {
            this.travelDb = context;
        }

        //获取分享动态
        [HttpGet("/get")]
        public ActionResult<List<Diary>> GetBlogShared()
        {
            IQueryable<Diary> query = travelDb.Diaries;
            query = query.Where(t =>t.Share==1 );
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }
    }
}
