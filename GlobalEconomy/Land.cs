using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GlobalEconomy
{
    class Land
    {

        // Average distance of town to town is 20km, city to city is 60km; 2 cells, 6 cells

        public Dictionary<Point, Plane> Lands { get; private set; } = new Dictionary<Point, Plane>();
        public List<Item> Resources { get; private set; } = new List<Item>();
        public List<Producer> Producers { get; private set; } = new List<Producer>();
        public static int Seed { get; private set; }
        public Land(int seed)
        {
            Seed = seed;
            ResourceInitialization();
            ProducerInitialization();
            LandInitialization();
        }

        public void LandInitialization()
        {
            var random = new Random(Seed);
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    var n = random.Next(1, 18);
                    var plane = (n > 12 && n > 16) ? new City() : (n > 12) ? new Town() : new Plane();
                    foreach (Producer pr in Producers)
                        plane.Producers.Add(pr, 0);
                    if (plane is City)
                    {
                        plane.Gold = random.Next(300, 1500) * 2;
                        for (int i = 0; i < random.Next(2, 5); i++)
                        {
                            var p = random.Next(0, Producers.Count);
                            var l = random.Next(1, 4);
                            plane.Producers[Producers[p]] += l;
                            plane.Shop = new Shop();
                            plane.Shop.Gold = plane.Gold;
                        }
                    }
                    else if (plane is Town)
                    {
                        plane.Gold = random.Next(300, 1500);
                        var p = random.Next(0, Producers.Count);
                        var l = random.Next(1, 2);
                        plane.Producers[Producers[p]] = l;
                        plane.Shop = new Shop();
                        plane.Shop.Gold = plane.Gold;
                    }
                    if (plane is Town || plane is City)
                    {
                        foreach(Item item in Resources)
                        {
                            Item it = item;
                            int r = plane is City ? random.Next(10, 100) : random.Next(5, 50);
                            it.ActualValue = (r / 10 * it.BaseValue) - (plane.Producers.First(p => p.Key.Resource.Name == it.Name).Value * plane.Producers.First(p => p.Key.Resource.Name == it.Name).Key.ResourcePerDay);
                            plane.Shop.Items.Add(it, r);
                        }
                    }
                    Lands.Add(new Point(x, y), plane);
                }
            }
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
