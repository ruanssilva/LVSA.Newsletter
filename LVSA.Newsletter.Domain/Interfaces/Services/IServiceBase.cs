using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity>
        where TEntity : class
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
