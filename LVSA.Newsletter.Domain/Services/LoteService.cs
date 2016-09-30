using LVSA.Newsletter.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LVSA.Newsletter.Domain.Interfaces.Repository;

namespace LVSA.Newsletter.Domain.Services
{
    public class LoteService : ServiceBase<Lote>, ILoteService
    {
        public LoteService(ILoteRepository repository) : base(repository)
        {
        }
    }
}
