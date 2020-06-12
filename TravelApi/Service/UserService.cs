using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface IUserService : IEntityService<User>
    {
    }

    public class UserService : EntityService<User>, IUserService
    {
        public UserService(TravelContext db) : base(db)
        {
        }

        public IQueryable<User> SelectAll()
        {
            return this.dbset.OrderByDescending(c=>c.Uid);
        }

        public User GetById(int uid)
        {
            return this.dbset.FirstOrDefault(u => u.Uid == uid);
        }
    }
}