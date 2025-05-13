using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle.Creatures {
    public class Classes {
        public int HitDice {  get; set; }
        public int[]? SpellSlots { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }

        public Classes(string _Name, int _HD, int[]? _SS = null, string tag= "") {
            Name = _Name;
            HitDice = _HD;
            SpellSlots = _SS;
            Tag = tag;
        }
    }
}
