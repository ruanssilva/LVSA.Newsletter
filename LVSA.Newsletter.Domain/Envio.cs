﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Domain
{
    public class Envio
    {
        public Guid Id { get; set; }
        public string Assunto { get; set; }
        public string Body { get; set; }
        public virtual ICollection<Destinatario> DestinatarioSet { get; set; }
    }
}