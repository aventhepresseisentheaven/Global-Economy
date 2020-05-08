using System;
using System.Collections.Generic;

namespace GlobalEconomy
{
    class Land
    {

        // Average distance of town to town is 15km-20km, city to city is 55km-70km

        public List<Plane>[,] Lands { get; private set; }
        public List<Item> Resources { get; private set; } = new List<Item>();
        public List<Producer> Producers { get; private set; } = new List<Producer>();

        public Land(int empires)
        {
            ResourceInitialization();
            ProducerInitialization();
        }

        public void ResourceInitialization()
        {
            Resources.Add(new Item("Iron", 20));
            Resources.Add(new Item("Silver", 30));
            Resources.Add(new Item("Gold", 50));
            Resources.Add(new Item("Apples", 3, 25));
            Resources.Add(new Item("Oats", 4, 35));
            Resources.Add(new Item("Barley", 5, 50));
            Resources.Add(new Item("Wheat", 10, 115));
            Resources.Add(new Item("Rye", 12, 130));
            Resources.Add(new Item("Linen", 5));
            Resources.Add(new Item("Wool", 10));
            Resources.Add(new Item("Leather", 15));
            Resources.Add(new Item("Animal Skins", 20));
            Resources.Add(new Item("Silk", 25));
        }

        public void ProducerInitialization()
        {
            Random r = new Random();
            foreach (Item item in Resources)
                Producers.Add(new Producer(item.Name + " Producer", item, r.Next(1, 5)));
        }
    }
}
