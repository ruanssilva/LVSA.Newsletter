using LVSA.Newsletter.Domain;
using LVSA.Newsletter.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Infrastructure.Data.Repository.EF
{
    public class EnvioRepository : RepositoryBase<Envio>, IEnvioRepository
    {
    }
}
