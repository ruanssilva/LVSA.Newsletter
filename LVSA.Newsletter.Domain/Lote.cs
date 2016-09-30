using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Domain
{
    public class Lote
    {
        public Guid Id { get; set; }
        public DateTime Horario { get; set; }
        public Guid EnvioId { get; set; }

        public virtual Envio Envio { get; set; }


    }
}
