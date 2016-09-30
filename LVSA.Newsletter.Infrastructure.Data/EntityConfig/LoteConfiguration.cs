﻿using LVSA.Newsletter.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Infrastructure.Data.EntityConfig
{
    public class LoteConfiguration : EntityTypeConfiguration<Lote>
    {
        public LoteConfiguration()
        {
            ToTable("Lote", "Newsletter");

            HasRequired(hr => hr.Envio)
                .WithMany()
                .HasForeignKey(fk => fk.EnvioId);


        }
    }
}
