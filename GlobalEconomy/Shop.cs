using System.Collections.Generic;

namespace GlobalEconomy
{
    class Shop
    {
        public int Gold { get; set; }
        // Items with Quantity
        public Dictionary<Item, int> Items { get; set; }


    }
}