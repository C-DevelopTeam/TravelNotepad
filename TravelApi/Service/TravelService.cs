using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface ITravelService : IEntityService<Travel>
    {
    }

    public class TravelService : EntityService<Travel>, ITravelService
    {
        public TravelService(TravelContext db) : base(db)
        {
        }

        public IQueryable<Travel> GetTravels()
        {
            return this.dbset;
        }

        public Travel GetById(long? travelId)
        {
            return this.dbset.FirstOrDefault(t => t.TravelId == travelId);
        }

        public IQueryable<Travel> GetByUid(int uid)
        {
            return this.dbset.Where(t => t.Uid == uid);
        }
    }
}