using LVSA.Newsletter.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Infrastructure.Data.EntityConfig
{
    public class EnviadoConfiguration : EntityTypeConfiguration<Enviado>
    {
        public EnviadoConfiguration()
        {
            ToTable("Enviado", "Newsletter");

            HasKey(hk => new { hk.DestinatarioId, hk.EnvioId });

            HasRequired(hr => hr.Destinatario)
                .WithMany()
                .HasForeignKey(fk => fk.DestinatarioId);

            HasRequired(hr => hr.Envio)
                .WithMany()
                .HasForeignKey(fk => fk.EnvioId);
        }
    }
}
