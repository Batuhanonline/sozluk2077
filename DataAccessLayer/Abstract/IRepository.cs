using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Add(T entity);
        T GetAll(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetFind(Expression<Func<T, bool>> filter);
    }
}
