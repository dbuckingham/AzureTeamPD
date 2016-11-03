using System.Data.Entity;
using Checklist.Web.Context;

namespace Checklist.Web.Configuration
{
    public static class Bootstrap
    {
        public static void Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
        }
    }
}