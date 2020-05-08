using System.Collections.Generic;

namespace GlobalEconomy
{
    class Town
    {
        public int Gold { get; set; }
        public int ShopCount { get; private set; }
        public List<Shop> Shops { get; set; }
        public Producer Producers { get; set; }
    }
}
