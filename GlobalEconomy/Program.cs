using System;
using System.Collections.Generic;

namespace GlobalEconomy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> resources = new List<Item>();
            resources.Add(new Item("Iron", 20));
            resources.Add(new Item("Silver", 30));
            resources.Add(new Item("Gold", 50));
            resources.Add(new Item("Apples", 3, 25));
            resources.Add(new Item("Oats", 4, 35));
            resources.Add(new Item("Barley", 5, 50));
            resources.Add(new Item("Wheat", 10, 115));
            resources.Add(new Item("Rye", 12, 130));
            resources.Add(new Item("Linen", 5));
            resources.Add(new Item("Wool", 10));
            resources.Add(new Item("Leather", 15));
            resources.Add(new Item("Animal Skins", 20));
            resources.Add(new Item("Silk", 25));

            Land game = new Land(3, resources);
        }
    }
}
