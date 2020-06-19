using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface ITravelService : IEntityService<Travel>
    {
        IQueryable<Travel> GetTravelByDate(string date);
        Travel GetById(long? travelId);
        IQueryable<Travel> GetByUid(int uid);
    }

    public class TravelService : EntityService<Travel>, ITravelService
    {
        public TravelService(TravelContext db) : base(db)
        {
        }

        public IQueryable<Travel> GetTravelByDate(string date)
        {
            return this.dbset.Where(t => t.TravelId.ToString().StartsWith(date)).OrderBy(t => t.TravelId);
        }

        public Travel GetById(long? travelId)
        {
            return this.dbset.FirstOrDefault(t => t.TravelId == travelId);
        }

        public IQueryable<Travel> GetByUid(int uid)
        {
            return this.dbset.Where(t => t.Uid == uid).OrderByDescending(t => t.TravelId);
        }
    }
}