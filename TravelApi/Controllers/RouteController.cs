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
    public class RouteController : ControllerBase
    {
        private readonly TravelContext travelDb;

        public RouteController(TravelContext context)
        {
            this.travelDb = context;
        }

        //新建路线
        [HttpPost]
        public ActionResult<Route> AddRoute(long travelid,Route route,Site startSite,Site endSite)
        {
            try
            {
                IQueryable<Route> query = travelDb.Routes;
                query = query.Where(t => t.TravelId == travelid).OrderByDescending(c=>c.RouteId);
                if(query!=null)
                {
                    route.RouteId = query.ToList().First().RouteId+1;
                }
                else
                {
                    route.RouteId = travelid*100+1;
                }
                travelDb.Sites.Add(startSite);
                travelDb.Sites.Add(endSite);
                travelDb.Routes.Add(route);
                travelDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return route;
        }

        //根据旅游id获取路线
        [HttpGet("/get")]
        public ActionResult<List<Route>> GetRoute(long travelid)
        {
            IQueryable<Route> query = travelDb.Routes;
            query = query.Where(t => t.TravelId == travelid);
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        //更该路线信息
        [HttpPut("/update")]
        public ActionResult<Route> UpdateRoute(long RouteId, Route route)
        {
            if (RouteId != route.RouteId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                travelDb.Entry(route).State = EntityState.Modified;
                travelDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        //按照id删除订单
        [HttpDelete("/delete")]
        public ActionResult DeleteRoute(long[] routeids)
        {
            try
            {
                for (int i = 0; i < routeids.Length; i++)
                {
                    var route = travelDb.Routes.FirstOrDefault(t => t.RouteId == routeids[i]);
                    if (route != null)
                    {
                        travelDb.Remove(route);
                        travelDb.SaveChanges();
                    }
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