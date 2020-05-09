using System.Collections.Generic;

namespace GlobalEconomy
{
    class City : Plane
    {

        public City()
        {
            // Resources of City start at x2
            // Value of item is (nearbyLandSupply / 10 * BaseValue) - (rpd * Producers) changes after a day

            Property = "City";
        }
    }
}
