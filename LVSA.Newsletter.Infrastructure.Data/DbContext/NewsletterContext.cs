using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LVSA.Newsletter.Infrastructure.Data.EntityConfig;

namespace LVSA.Newsletter.Infrastructure.Data.DbContext
{
    public class NewsletterContext : System.Data.Entity.DbContext
    {
        public NewsletterContext()
            :base("Data Source=localhost;Initial Catalog=Newsletter;Integrated Security=False;User ID=sa;Password=admServ2;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(c => c.IsKey());            

            modelBuilder.Properties<string>()
                .Configure(c =>
                {
                    c.HasColumnType("varchar");                    
                    c.HasMaxLength(65);
                });

            modelBuilder.Properties<string>()
                .Where(p => p.Name == "Descricao")
                .Configure(c => c.HasMaxLength(255));

            modelBuilder.Configurations.Add(new DestinatarioConfiguration());
            modelBuilder.Configurations.Add(new EnvioConfiguration());
            modelBuilder.Configurations.Add(new LoteConfiguration());
            modelBuilder.Configurations.Add(new RemetenteConfiguration());
            modelBuilder.Configurations.Add(new ServidorConfiguration());
            modelBuilder.Configurations.Add(new EnviadoConfiguration());



            //base.OnModelCreating(modelBuilder);
        }

    }
}
