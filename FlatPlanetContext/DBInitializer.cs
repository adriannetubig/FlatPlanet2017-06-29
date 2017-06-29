using System.Data.Entity;

namespace FlatPlanetContext
{
    public class DBInitializer : CreateDatabaseIfNotExists<Context>
    {
        public DBInitializer()
        {
        }
        protected override void Seed(Context context)
        {
        }
    }
}
