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
    public class RouteController : ControllerBase
    {
        private readonly IRouteService _routeService;

        public RouteController(IRouteService routeService)
        {
            this._routeService = routeService;
        }

        //新建路线
        [HttpPost]
        public ActionResult<Route> AddRoute(Route route)
        {
            try
            {
                IQueryable<Route> query = _routeService.GetByTravelId(route.TravelId);
                if(query!=null)
                {
                    route.RouteId = query.ToList().First().RouteId+1;
                }
                else
                {
                    route.RouteId = route.TravelId*100+1;
                }
                _routeService.Add(route);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return route;
        }

        //根据旅游id获取路线
        [HttpGet("get")]
        public ActionResult<List<Route>> GetRoute(long travelId)
        {
            IQueryable<Route> query = _routeService.GetByTravelId(travelId);
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        //更该路线信息
        [HttpPut("update")]
        public ActionResult<Route> UpdateRoute(long routeId, Route route)
        {
            if (routeId != route.RouteId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _routeService.Update(route);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        //按照id删除路线
        [HttpDelete("delete")]
        public ActionResult DeleteRoute(long routeId)
        {
            try
            {
                var route = _routeService.GetById(routeId);
                if (route != null)
                {
                     _routeService.Delete(route);
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