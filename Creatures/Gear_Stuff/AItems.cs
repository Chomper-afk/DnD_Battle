using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle.Creatures.Gear_Stuff {
    public abstract class AItems {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract int Amount { get; set; }
        public abstract string Type {  get; set; }
        public abstract int Action {  get; set; }
        public abstract void Use_Other(ACreature User, ACreature Target);
        public abstract void Use_Sefl(ACreature User);
        public abstract void Use_Special(ACreature User);
        public override string ToString() {
            char A = 'a';
            if (Action == 1) A = 'A';
            if (Action == 2) A = 'B';
            return $"{Amount,000}|{A}|{Name}";
        }
    }
}
