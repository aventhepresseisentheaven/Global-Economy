using System.Collections.Generic;

namespace GlobalEconomy
{
    class Shop
    {
        // Items, Quantity
        public Dictionary<Item, int> Items { get; set; }
        public int Gold { get; set; }

        public override string ToString()
        {
            string end = string.Empty;
            end += $"\t\tShop\t\t|\t\tGold in Shop: {Gold}\n";
            end += "---------------------------------------------------------\n";
            int n = 0;
            foreach(KeyValuePair<Item, int> ItemNQuantity in Items)
            {
                end += $"[{n++}]{ItemNQuantity.Key.Name,10}{ItemNQuantity.Key.ActualValue,10}\t\t|\t\t{ItemNQuantity.Value,-10}\n";
            }
            end += "---------------------------------------------------------\n";

            return end;
        }
    }
}