using LVSA.Newsletter.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using LVSA.Newsletter.Domain.Interfaces.Services;
using AutoMapper;

namespace LVSA.Newsletter.Application
{
    public class AppServiceBase<TViewModel, TEntity, TIService> : IAppServiceBase<TViewModel, TEntity>
        where TViewModel : class
        where TEntity : class
        where TIService : IServiceBase<TEntity>
    {
        protected readonly TIService Service;

        public AppServiceBase(TIService _service)
        {
            Service = _service;
        }

        public TViewModel Atualizar(TViewModel model)
        {
            return Mapper.Map<TEntity, TViewModel>(Service.Update(Mapper.Map<TViewModel, TEntity>(model)));
        }

        public IEnumerable<TViewModel> Filtrar(Expression<Func<TEntity, bool>> predicate)
        {
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TViewModel>>(Service.Find(predicate));
        }

        public TViewModel Incluir(TViewModel model)
        {
            return Mapper.Map<TEntity, TViewModel>(Service.Add(Mapper.Map<TViewModel, TEntity>(model)));
        }

        public void Remover(TViewModel model)
        {
            Service.Delete(Mapper.Map<TViewModel, TEntity>(model));
        }
    }
}
