using LVSA.Newsletter.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Infrastructure.Data.EntityConfig
{
    public class EnvioConfiguration : EntityTypeConfiguration<Envio>
    {
        public EnvioConfiguration()
        {
            ToTable("Envio", "Newsletter");

            Property(p => p.Body)
                .HasColumnType("text")
                .HasMaxLength(100000);

            //HasMany(hm => hm.DestinatarioSet)
            //    .WithMany(wm => wm.EnvioSet)
            //    .Map(m =>
            //    {
            //        m.ToTable("Enviado", "Newsletter");
            //        m.MapLeftKey("DestinatarioId");
            //        m.MapRightKey("EnvioId");
            //    });
        }
    }
}
