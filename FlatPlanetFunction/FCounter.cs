using FlatPlanetData;
using FlatPlanetEntity;
using System;

namespace FlatPlanetFunction
{
    public class FCounter : IFCounter
    {
        private IDCounter _iDCounter;

        public FCounter (IDCounter iDCounter)
        {
            _iDCounter = iDCounter;
        }

        public void Create()
        {
            if (Count() >= 10)
                return;

            ECounter counter = new ECounter
            {
                CreatedDate = DateTime.UtcNow
            };

            _iDCounter.Create(counter);
        }

        public int Count()
        {
            return _iDCounter.Count();
        }
    }
}
