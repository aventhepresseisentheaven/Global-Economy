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
    }
}
