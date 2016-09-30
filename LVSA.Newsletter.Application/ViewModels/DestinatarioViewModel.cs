using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.ViewModels
{
    public class DestinatarioViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public virtual IEnumerable<EnvioViewModel> EnvioSet { get; set; }
    }
}
