using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    public class Spellcasting {


        public Spellcasting(int[] spellSlots = null) {
            
            SpellSlots = spellSlots ?? [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        }
        public int[] SpellSlots { get; set; } = new int[10];
    }
}
