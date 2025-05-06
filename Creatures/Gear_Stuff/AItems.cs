using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle.Creatures.Gear_Stuff {
    public abstract class AItems {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public abstract void Use_Sefl();
        public abstract void Use_Other();
    }
}
