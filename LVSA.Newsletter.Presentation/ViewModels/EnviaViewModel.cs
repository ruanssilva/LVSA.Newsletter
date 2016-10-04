using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LVSA.Newsletter.Presentation.ViewModels
{
    public class EnviaViewModel : IValidatableObject
    {
        public string Tipo { get; set; }
        [Required]
        public Guid ServidorId { get; set; }
        [Required]
        public Guid RemetenteId { get; set; }
        public string Assunto { get; set; }
        public string Body { get; set; }
        public string SMS { get; set; }
        [Required]
        public HttpPostedFileBase Arquivo { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Tipo == "Text/SMS")
            {
                if (string.IsNullOrWhiteSpace(SMS))
                    yield return new ValidationResult("O campo é obrigatório.", new[] { "SMS" });

            }
            else if (Tipo == "Mail")
            {
                if (string.IsNullOrWhiteSpace(Assunto))
                    yield return new ValidationResult("O campo é obrigatório.", new[] { "Assunto" });
                if (string.IsNullOrWhiteSpace(Body))
                    yield return new ValidationResult("O campo é obrigatório.", new[] { "Body" });
            }
        }
    }
}