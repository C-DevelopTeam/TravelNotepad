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
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            this._taskService = taskService;
        }

        //新建待办
        [HttpPost]
        public ActionResult<Task> AddTask(Task task)
        {
            try{
                IQueryable<Task> query = _taskService.GetByRouteId(task.RouteId);
                if(query!=null)
                {
                    task.TaskId = query.ToList().First().TaskId+1;
                }
                else
                {
                    task.TaskId = task.RouteId*100+1;
                }
                _taskService.Add(task);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return task;
        }

        //根据地点id获取待办
        [HttpGet("/get")]
        public ActionResult<List<Task>> GetRoute(long routeId)
        {
            IQueryable<Task> query = _taskService.GetByRouteId(routeId);
            if(query==null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        //更该待办信息
        [HttpPut("/update")]
        public ActionResult<Task> UpdateRoute(long taskId, Task task)
        {
            if (taskId != task.TaskId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _taskService.Update(task);
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
        public ActionResult DeleteRoute(long taskId)
        {
            try
            {
                var task = _taskService.GetById(taskId);
                if (task != null)
                {
                    _taskService.Delete(task);
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