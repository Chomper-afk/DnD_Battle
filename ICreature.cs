using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal interface ICreature {
        public string Name { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON { get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        public int BaseHP { get; set; }
        public int CurrentHP { get; set; }
        public Spellcasting SpellSlots { get; set; }
        public bool IsRaging { get; set; }
        public int AC { get; set; }
        public Dice Melee_attack { get; set; }
        public int STR_Modifier { get; set; }
        public int DEX_Modifier { get; set; }
        public int CON_Modifier { get; set; }
        public int INT_Modifier { get; set; }
        public int WIS_Modifier { get; set; }
        public int CHA_Modifier { get; set; }
        public int SpellcastingModifier {  get; set; }


        public void Attack(int dmg) {
        }
        public string HP_Check() => $"{CurrentHP}/{BaseHP}";

        }
    }

