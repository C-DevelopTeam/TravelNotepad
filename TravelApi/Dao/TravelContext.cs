using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Dao
{
    public class TravelContext : DbContext{
        public TravelContext(DbContextOptions<TravelContext> options) : base(options){
            this.Database.EnsureCreated();
        }        
    }
}