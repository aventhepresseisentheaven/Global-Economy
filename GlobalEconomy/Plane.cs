using System.Collections.Generic;

namespace GlobalEconomy
{
    class Plane
    {
        // "City" "Town" "None"
        public string Property { get; set; }
        public int Gold { get; set; }
        public Shop Shop { get; set; }
        public Dictionary<Producer, int> Producers { get; set; } = new Dictionary<Producer, int>();

        public Plane()
        {
            Property = "None";
        }
        

    }
}
