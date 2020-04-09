using System;
using System.Collections.Generic;
using System.Text;

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
