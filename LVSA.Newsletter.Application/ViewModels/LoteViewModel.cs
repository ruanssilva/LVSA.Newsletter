using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.ViewModels
{
    public class LoteViewModel
    {
        public Guid Id { get; set; }
        public DateTime Horario { get; set; }
        public Guid EnvioId { get; set; }

        public EnvioViewModel Envio { get; set; }
    }
}
