using Microsoft.EntityFrameworkCore;
using StartupCase_DataAccess.Abstract;
using System.Linq.Expressions;

namespace StartupCase_DataAccess.Concrate.Ef
{
    public class RepositoryDal<T, TEntity> : IRepository<T> where T : class where TEntity : DbContext, new()
    {
        public T Create(T entity)
        {
            using (var db = new TEntity())
            {
                var data = db.Set<T>().Add(entity);
                db.SaveChanges();
                return data.Entity;
            }
        }

        public T Delete(T entity)
        {
            using (var db = new TEntity())
            {
                var data = db.Set<T>().Remove(entity);
                db.SaveChanges();
                return data.Entity;
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var db = new TEntity())
            {
                return filter == null
                    ? db.Set<T>().ToList()
                    : db.Set<T>().Where(filter).ToList();
            }
        }
        public T GetById(int id)
        {
            using (var db = new TEntity())
            {
                var find = db.Set<T>().Find(id);
                return find;
            }
        }
        public T Update(T entity)
        {
            using (var db = new TEntity())
            {
                var data = db.Set<T>().Update(entity);
                db.SaveChanges();
                return data.Entity;
            }
        }
    }
}
