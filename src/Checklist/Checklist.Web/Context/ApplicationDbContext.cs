using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Checklist.Web.Configuration.Convention;
using Checklist.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Checklist.Web.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Add<ForeignKeyColumnNamingConvention>();

            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}