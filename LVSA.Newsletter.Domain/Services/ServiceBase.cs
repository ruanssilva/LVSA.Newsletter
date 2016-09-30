using LVSA.Newsletter.Domain.Interfaces.Repository;
using LVSA.Newsletter.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace LVSA.Newsletter.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : class
    {
        protected readonly IRepositoryBase<TEntity> Repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            Repository = repository;
        }

        public TEntity Add(TEntity entity)
        {
            Repository.Add(entity);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            Repository.Delete(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Find(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            Repository.Update(entity);
            return entity;
        }
    }
}
