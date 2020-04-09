using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalEconomy
{
    class Item
    {
        private bool consumable;
        private int fulfillment;
        public string Name { get; set; }
        // Actual value in towns have multiplier based on scarcity
        public int BaseValue { get; set; }
        public int ActualValue { get; set; }
        public bool Consumable { get => consumable; set => consumable = false; }
        public int Fulfillment { get => fulfillment; set => fulfillment = 0; }
        public Item(string name, int val)
        {
            Name = name;
            BaseValue = val;
        }
        public Item(string name, int val, int fulfillment)
        {
            Name = name;
            BaseValue = val;
            consumable = true;
            this.fulfillment = fulfillment;
        }
    }
}
