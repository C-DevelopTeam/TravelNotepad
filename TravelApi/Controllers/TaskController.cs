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
    public class TaskController : ControllerBase
    {
        private readonly TravelContext travelDb;

        public TaskController(TravelContext context)
        {
            this.travelDb = context;
        }

        //新建待办
        [HttpPost]
        public ActionResult<TravelApi.Models.Task> AddTask(int routeid,TravelApi.Models.Task task)
        {
            try{
                IQueryable<TravelApi.Models.Task> query = travelDb.Tasks;
                query = query.Where(t => t.RouteId == routeid).OrderByDescending(c=>c.TaskId);
                if(query!=null)
                {
                    task.TaskId = query.ToList().First().TaskId+1;
                }
                else
                {
                    task.TaskId = routeid*100+1;
                }
                travelDb.Tasks.Add(task);
                travelDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return task;
        }

        //根据地点id获取待办
        [HttpGet("/post")]
        public ActionResult<List<TravelApi.Models.Task>> GetRoute(int routeid)
        {
            IQueryable<TravelApi.Models.Task> query = travelDb.Tasks;
            query = query.Where(t => t.RouteId == routeid);
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        //更该待办信息
        [HttpPut("/update")]
        public ActionResult<TravelApi.Models.Task> UpdateRoute(int taskid, TravelApi.Models.Task task)
        {
            if (taskid != task.TaskId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                travelDb.Entry(task).State = EntityState.Modified;
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

        //按照id删除待办
        [HttpDelete("/delete")]
        public ActionResult DeleteRoute(int taskid)
        {
            try
            {
                var route = travelDb.Tasks.FirstOrDefault(t => t.TaskId == taskid);
                if (route != null)
                {
                    travelDb.Remove(route);
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