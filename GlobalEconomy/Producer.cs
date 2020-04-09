using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalEconomy
{
    class Producer
    {
        public string Name { get; set; }
        public Item Resource { get; set; }
        public int ResourcePerDay { get; set; }
        public Producer(string name, Item resource, int rpd)
        {
            Name = name;
            Resource = resource;
            ResourcePerDay = rpd;
        }
    }
}
