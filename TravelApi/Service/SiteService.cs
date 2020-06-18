using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface ISiteService : IEntityService<Site>
    {
        Site GetById(string siteId);
    }

    public class SiteService : EntityService<Site>, ISiteService
    {
        public SiteService(TravelContext db) : base(db)
        {
        }

        public Site GetById(string siteId)
        {
            return this.dbset.FirstOrDefault(s => s.SiteId == siteId);
        }
    }
}