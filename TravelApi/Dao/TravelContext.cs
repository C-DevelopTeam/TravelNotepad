using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Dao
{
    public class TravelContext : DbContext{
        public TravelContext(DbContextOptions<TravelContext> options) : base(options){
            this.Database.EnsureCreated();
        }

        public DbSet<User> User {get; set;}
        public DbSet<Diary> Diary{get; set;}
        public DbSet<Route> Route{get; set;}
        public DbSet<Site> Site{get; set;}
        public DbSet<Task> Task{get; set;}
        public DbSet<Travel> Travel{get; set;}
    }
}