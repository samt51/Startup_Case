using System.Linq.Expressions;

namespace StartupCase_DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
