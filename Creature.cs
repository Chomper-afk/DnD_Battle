using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal class Creature : ICreature {

        /// <summary>
        /// base stats of a creature.
        /// </summary>
        /// <param name="name">Name of a creature</param>
        /// <param name="sTR">Strenght</param>
        /// <param name="dEX">Dexterity</param>
        /// <param name="cON">Constution</param>
        /// <param name="iNT">Intelligence</param>
        /// <param name="wIS">Wisdom</param>
        /// <param name="cHA">Charisma</param>
        /// <param name="baseHP">Base HP</param>
        /// <param name="spellSlots">how much spell slots does creature have, [0] should be really high so that you can cast cnatripts.</param>
        public Creature(string name, Spellcasting spellSlots, int _STR = 10, int _DEX = 10, int _CON = 10, int _INT = 10, int _WIS = 10, int _CHA = 10, int ac = 10,
            int baseHP = 20, int currentHP = 20, Dice? melee_attack = null, List<Effect>? _Effects = null) {

            Name = name;
            STR = new Stat(_STR, 0, 100);
            DEX = new Stat(_DEX, 0, 100);
            CON = new Stat(_CON, 0, 100);
            INT = new Stat(_INT, 0, 100);
            WIS = new Stat(_WIS, 0, 100);
            CHA = new Stat(_CHA, 0, 100);
            BaseHP = baseHP;
            CurrentHP = currentHP;
            SpellSlots = spellSlots;
            Melee_attack = melee_attack ?? new Dice(0, 5, 0, 0, 0, 0, 0);
            AC_Base = ac;
            SpellcastingModifier = CHA.Modifier;
            if (_Effects != null) {
                foreach (Effect E in _Effects) {
                    Effects.Add(E);
                }
            }
            else
                Effects = null;
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
        public int AC { get { return (AC_Base + DEX.Modifier); } }
        public Dice Melee_attack { get; set; }
        public float RES_Pierce { get; set; }
        public float RES_Blunt { get; set; }
        public float RES_Sharp { get; set; }
        public float RES_Heal { get; set; }
        public List<Effect>? Effects { get; set; }

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
