using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Domain
{
    public class Enviado
    {
        public Guid EnvioId { get; set; }
        public Guid DestinatarioId { get; set; }
        public virtual Envio Envio { get; set; }
        public virtual Destinatario Destinatario { get; set; }
    }
}
