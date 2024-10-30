using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal class Spellcasting {


        public Spellcasting(int[] spellSlots = null) {
            
            SpellSlots = spellSlots ?? new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }
        public int[] SpellSlots { get; set; } = new int[10];
    }
}
