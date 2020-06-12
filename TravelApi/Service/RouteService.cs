using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface IRouteService : IEntityService<Route>
    {
    }

    public class RouteService : EntityService<Route>, IRouteService
    {
        public RouteService(TravelContext db) : base(db)
        {
        }

        public IQueryable<Route> GetRoutes()
        {
            return this.dbset;
        }

        public IQueryable<Route> GetByTravelId(long travelId)
        {
            return this.dbset.Where(r => r.TravelId == travelId).OrderByDescending(c=>c.RouteId);
        }

        public Route GetById(long routeId)
        {
            return this.dbset.FirstOrDefault(r => r.RouteId == routeId);
        }
    }
}