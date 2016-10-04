using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LVSA.Newsletter.Presentation.ViewModels
{
    public class EnviaViewModel
    {
        public Guid ServidorId { get; set; }
        public Guid RemetenteId { get; set; }
        public string Assunto { get; set; }
        public string Body { get; set; }
        public string SMS { get; set; }
    }
}