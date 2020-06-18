using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface ITaskService : IEntityService<Task>
    {
        Task GetById(long taskId);
        IQueryable<Task> GetByRouteId(long routeId);
    }

    public class TaskService : EntityService<Task>, ITaskService
    {
        public TaskService(TravelContext db) : base(db)
        {
        }

        public Task GetById(long taskId)
        {
            return this.dbset.FirstOrDefault(t => t.TaskId == taskId);
        }

        public IQueryable<Task> GetByRouteId(long routeId)
        {
            return this.dbset.Where(t => t.RouteId == routeId).OrderByDescending(c=>c.TaskId);
        }
    }
}