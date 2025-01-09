using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    public interface ICreature {
        public string Name { get; set; }
        public Stat STR { get; set; }
        public Stat DEX { get; set; }
        public Stat CON { get; set; }
        public Stat INT { get; set; }
        public Stat WIS { get; set; }
        public Stat CHA { get; set; }
        public int BaseHP { get; set; }
        public int CurrentHP { get; set; }
        public Spellcasting SpellSlots { get; set; }
        public bool IsRaging { get; set; }
        public int AC { get;}
        public Dice Melee_attack { get; set; }
        public int SpellcastingModifier {  get; set; }

        public float RES_Pierce { get; set; }
        public float RES_Blunt { get; set; }
        public float RES_Sharp { get; set; }
        public float RES_Heal { get; set; }

        public List<Effect>? Effects { get; set; }

        public void Attack(int dmg) {
        }
        public string HP_Check() => $"{CurrentHP}/{BaseHP}";

        }
    }

