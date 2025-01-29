using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal class Player : ICreature {
        public Player(string name, Spellcasting spellSlots, int _STR = 10, int _DEX = 10, int _CON = 10, int _INT = 10, int _WIS = 10, int _CHA = 10, int ac = 10,
            int baseHP = 20, int currentHP = 20, Dice? melee_attack = null, List<Effect>? _Effects = null) {
            
            
            Name = name;
            STR = new Stat(_STR, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => count(Effects => Effects.STR));
            DEX = new Stat(_DEX, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => count(Effects => Effects.DEX));
            CON = new Stat(_CON, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => count(Effects => Effects.CON));
            INT = new Stat(_INT, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => count(Effects => Effects.INT));
            WIS = new Stat(_WIS, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => count(Effects => Effects.WIS));
            CHA = new Stat(_CHA, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => count(Effects => Effects.CHA));
            BaseHP = baseHP;
            CurrentHP = currentHP;
            SpellSlots = spellSlots;
            Melee_attack = melee_attack ?? new Dice(0, 0, 0, 0, 0, 0, 0);
            AC_Base = ac ;
            if (_Effects != null) {
                foreach (Effect E in _Effects) {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    Effects.Add(E);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
        public int SpellcastingModifier { get { return CHA.Modifier; } }
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
        public List<Effect>? Effects { get; set; } = new List<Effect>();
        public float RES_Pierce { get; set; } = 1;
        public float RES_Blunt { get; set; } = 1;
        public float RES_Sharp { get; set; } = 1;
        public float RES_Heal { get; set; } = 1;

        private int AC_Base;

        private int count(Func<Effect, int> selector) {
            int total = 0;
            if (Effects != null) {
                foreach (Effect E in Effects) {
                    total += selector(E);
                }
            }
            return total;
        }
        private int Minimum_stat_V(Func<Effect, int> selector) {
            int min = 0;
            int temp = 0;
            if (Effects != null) {
                foreach (Effect E in Effects) {
                    temp += selector(E);
                    if (min < temp) min = temp;
                }
            }
            return min;
        }
        private int Maximum_stat_V(Func<Effect, int> selector) {
            int max = 100;
            int temp = 0;
            if (Effects != null) {
                foreach (Effect E in Effects) {
                    temp += selector(E);
                    if (max < temp) max = temp;
                }
            }
            return max;
        }
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
