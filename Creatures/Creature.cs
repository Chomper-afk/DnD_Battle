using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using DnD_Battle.Spell_Stuff;

namespace DnD_Battle.Creatures {
    internal class Creature : ACreature {
        public Creature(string name, Spellcasting spellSlots, int _STR = 10, int _DEX = 10, int _CON = 10, int _INT = 10, int _WIS = 10, int _CHA = 10, int ac = 10,
            int baseHP = 20, int currentHP = 20, Dice? melee_attack = null, List<Effect>? _Effects = null) : base(name, spellSlots, _STR, _DEX, _CON, _INT, _WIS, _CHA, ac, baseHP, currentHP,
            melee_attack, _Effects) { }

        public override int BaseHP { get; set; }
    }
}
