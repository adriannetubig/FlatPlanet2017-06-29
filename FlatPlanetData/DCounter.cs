using FlatPlanetContext;
using FlatPlanetEntity;
using System.Linq;

namespace FlatPlanetData
{
    public class DCounter: IDCounter
    {
        public void Create(ECounter eCounter)
        {
            using (var context = new Context())
            {
                context.Counters.Add(eCounter);
                context.SaveChanges();
            }
        }

        public int Count()
        {
            using (var context = new Context())
            {
                return context.Counters.Count();
            }
        }
    }
}
