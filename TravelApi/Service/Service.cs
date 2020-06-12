using System;
using Microsoft.EntityFrameworkCore;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface IEntityService<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    public abstract class EntityService<T> : IEntityService<T> where T : class
    {
        protected TravelContext db;
        protected DbSet<T> dbset;

        public EntityService(TravelContext db)
        {
            this.db = db;
            dbset = db.Set<T>();
        }

        public virtual void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("请提供泛型类别");
            dbset.Add(entity);
            db.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("请提供泛型类别");
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("请提供泛型类别");
            dbset.Remove(entity);
            db.SaveChanges();
        }
    }
}