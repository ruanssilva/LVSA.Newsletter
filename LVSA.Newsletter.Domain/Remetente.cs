using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Domain
{
    public class Remetente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Exibicao { get; set; }
        public string Descricao { get; set; }
    }
}
