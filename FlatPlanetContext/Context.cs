using FlatPlanetEntity;
using System.Data.Entity;

namespace FlatPlanetContext
{
    public class Context : DbContext
    {
        public Context() : base("FlatPlanet")
        {

            if (Database.Exists())
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());
            }
            else
            {
                Database.SetInitializer(new DBInitializer());
            }
        }

        public DbSet<ECounter> Counters { get; set; }
    }
}
