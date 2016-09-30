namespace LVSA.Newsletter.Infrastructure.Data.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LVSA.Newsletter.Infrastructure.Data.DbContext.NewsletterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LVSA.Newsletter.Infrastructure.Data.DbContext.NewsletterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.Set<Servidor>().AddOrUpdate(
            //  new Servidor { Id = Guid.NewGuid(), Nome = "Servidor", Descricao = "Descrição" },
            //  new Servidor { Id = Guid.NewGuid(), Nome = "Servidor2", Descricao = "Descrição2" }
            //);
            //
        }
    }
}
