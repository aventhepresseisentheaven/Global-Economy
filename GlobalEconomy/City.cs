using System.Collections.Generic;

namespace GlobalEconomy
{
    class City
    {

        public int Gold { get; set; }
        public int ShopCount { get; private set; }
        public List<Shop> Shops { get; set; }
        public Dictionary<Producer, int> Producers { get; set; }

        public City()
        {
            // Resources of City start at x2
            // Value of item is (nearbyLandSupply / 10 * BaseValue) - (rpd * Producers
            
        }
    }
}
