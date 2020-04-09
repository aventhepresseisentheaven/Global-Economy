using System;
using System.Collections.Generic;
using System.Text;

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
            // Value of item is kmDistanceToProducer / 25 * BaseValue + BaseValue

        }
    }
}
