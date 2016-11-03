using System.Linq;
using Checklist.Web.Context;
using Checklist.Web.Migrations.Factories;

namespace Checklist.Web.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

#if DEBUG
            if (!context.Set<Data.Checklist>().Any())
            {
                context.Set<Data.Checklist>().AddOrUpdate(cl => cl.Name, ChecklistFactory.All);
                context.SaveChanges();

                ChecklistFactory.All = context.Set<Data.Checklist>().ToArray();

                context.Set<Data.ChecklistItem>().AddOrUpdate(cli => cli.Description, ChecklistItemFactory.All);
                context.SaveChanges();

                ChecklistItemFactory.All = context.Set<Data.ChecklistItem>().ToArray();
            }
#endif
        }
    }
}
