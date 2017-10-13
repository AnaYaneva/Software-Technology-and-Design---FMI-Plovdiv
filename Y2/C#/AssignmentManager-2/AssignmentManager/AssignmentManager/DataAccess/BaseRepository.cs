using AssignmentManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace AssignmentManager.DataAccess
{
    public abstract class BaseRepository<T>
        where T:BaseEntity
    {
        private DbContext context;
        private DbSet<T> dbSet;

        public BaseRepository()
        {
            context = new AssignmentManagerDbContext();
            dbSet = context.Set<T>();
        }

        public List<T> GetAll(Expression<Func<T,bool>> filter)
        {
            return dbSet.Where(filter).ToList();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
