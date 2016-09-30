using LVSA.Newsletter.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using LVSA.Newsletter.Infrastructure.Data.DbContext;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Metadata.Edm;

namespace LVSA.Newsletter.Infrastructure.Data.Repository.EF
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class
    {
        private readonly System.Data.Entity.DbContext _context;
        private readonly IDbSet<TEntity> _dbSet;
        private readonly ObjectContext _objectContext;
        private readonly ObjectStateManager _objectStateManager;
        private readonly EntityContainer _entityContainer;
        private readonly EntitySetBase _entitySetBase;

        public RepositoryBase()
        {
            _context = new NewsletterContext();
            _dbSet = _context.Set<TEntity>();
            _objectContext = ((IObjectContextAdapter)_context).ObjectContext;
            _objectStateManager = _objectContext.ObjectStateManager;
            _entityContainer = _objectContext.MetadataWorkspace.GetEntityContainer(_objectContext.DefaultContainerName, DataSpace.CSpace);
            _entitySetBase = _entityContainer.BaseEntitySets.Where(w => w.ElementType.Name.Equals(typeof(TEntity).Name)).FirstOrDefault();
        }

        public void Add(TEntity entity)
        {
            entity = _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            ObjectStateEntry state;

            bool attach = _objectStateManager.TryGetObjectStateEntry(_objectContext.CreateEntityKey(_entitySetBase.Name, entity), out state);
            if (!attach)
                _context.Entry(entity).State = EntityState.Deleted;
            else
                state.Delete();

            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public void Update(TEntity entity)
        {
            ObjectStateEntry state;

            bool attach = _objectStateManager.TryGetObjectStateEntry(_objectContext.CreateEntityKey(_entitySetBase.Name, entity), out state);
            if (!attach)
                _context.Entry(entity).State = EntityState.Modified;
            else
                state.SetModified();

            _context.SaveChanges();
        }
    }
}
