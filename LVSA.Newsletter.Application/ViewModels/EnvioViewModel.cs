using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.ViewModels
{
    public class EnvioViewModel
    {
        public Guid Id { get; set; }
        public string Assunto { get; set; }
        public string Body { get; set; }
        public IEnumerable<DestinatarioViewModel> DestinatarioSet { get; set; }
    }
}
