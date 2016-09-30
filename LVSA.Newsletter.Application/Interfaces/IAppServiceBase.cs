using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.Interfaces
{
    public interface IAppServiceBase<TViewModel, TEntity>
    {
        IEnumerable<TViewModel> Filtrar(Expression<Func<TEntity, bool>> predicate);
        void Remover(TViewModel model);
        TViewModel Atualizar(TViewModel model);
        TViewModel Incluir(TViewModel model);
    }
}
