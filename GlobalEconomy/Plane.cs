using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalEconomy
{
    class Plane
    {
        // "City" "Town" "None"
        public string Property { get; private set; }
        public City CityProperty { get; set; }
        public Town TownProperty { get; set; }

        public Plane(City city)
        {
            CityProperty = city;
            Property = "City";
        }
        
        public Plane(Town town)
        {
            TownProperty = town;
            Property = "Town";
        }

    }
}
