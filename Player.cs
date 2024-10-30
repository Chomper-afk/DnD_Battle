using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal class Player : Creature {
        public Player(string name, Spellcasting spellslots, int sTR = 10, int dEX = 10, int cON = 10, int iNT = 10, int wIS = 10, int cHA = 10, int ac = 10, int baseHP = 20, Dice melee_attack = null ) : base(name, spellslots, sTR, dEX, cON, iNT, wIS, cHA,ac, baseHP, melee_attack) {
            SpellcastingModifier = (CHA - 10) / 2;
            AC += DEX;
        }
        public int SpellcastingModifier { get; set; }
    }
}
