using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelContext : DbContext{
        public TravelContext(DbContextOptions<TravelContext> options) : base(options){
            this.Database.EnsureCreated();
        }

        //todo: 声明所有表Dbset
        
    }
}