using FlatPlanetEntity;

namespace FlatPlanetData
{
    public interface IDCounter
    {
        void Create(ECounter eCounter);
        int Count();
    }
}
