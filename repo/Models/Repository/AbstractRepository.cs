using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace repo.Models.Repository
{
    public abstract class AbstractRepository<T> where T : class
    {
        public virtual void Create(T model)
        {
            using (var context = new AutoContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual List<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            using (var context = new AutoContext())
            {
                var query = context.Set<T>().Where(expression);
                return query.ToList();

            }
        }

        public virtual void Edit(T model)
        {
            using (var context = new AutoContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        public virtual void Delete(T model)
        {
            using (var context = new AutoContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public virtual List<T> GetWhereWithIncludes(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            using (var context = new AutoContext())
            {
                IQueryable<T> dataset = context.Set<T>();
                if (includes.Any())
                {
                    foreach (var item in includes)
                    {
                        dataset = dataset.Include(item);
                    }
                }
                if (expression != null)
                    dataset = dataset.Where(expression);
                return dataset.ToList();

            }
        }
    }
}