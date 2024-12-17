using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal class Player : ICreature {
        public Player(string name, Spellcasting spellSlots, Stat? sTR = null, Stat? dEX = null, Stat? cON = null, Stat? iNT = null, Stat? wIS = null, Stat? cHA = null, int ac = 10, int baseHP = 20, int currentHP = 20, Dice? melee_attack = null ) {
            
            
            Name = name;
            STR = sTR ?? new Stat(10, 0, 100);
            DEX = dEX ?? new Stat(10, 0, 100);
            CON = cON ?? new Stat(10, 0, 100);
            INT = iNT ?? new Stat(10, 0, 100);
            WIS = wIS ?? new Stat(10, 0, 100);
            CHA = cHA ?? new Stat(10, 0, 100);
            BaseHP = baseHP;
            CurrentHP = currentHP;
            SpellSlots = spellSlots;
            Melee_attack = melee_attack ?? new Dice(0, 0, 0, 0, 0, 0, 0);
            AC_Base = ac ;
            SpellcastingModifier = CHA.Modifier;
        }
        public int SpellcastingModifier { get; set; }
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
        public int AC { get { return (AC_Base + DEX.Modifier); }  }
        public Dice Melee_attack { get; set; }

        private int AC_Base;

        public void Attack(int dmg) {
            CurrentHP -= dmg;
            if (CurrentHP < 0) {
                CurrentHP = 0;
                Console.WriteLine(Name + " has died!!");
                Settings.Log += "\r\n" + Name + " has died";
            }
            if (CurrentHP > BaseHP) {
                CurrentHP = BaseHP;
            }
        }
        public string HP_Check() {
            return CurrentHP + "/" + BaseHP;
        }
    }
}
