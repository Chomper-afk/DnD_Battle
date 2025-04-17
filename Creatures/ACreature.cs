using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Battle.Spell_Stuff;

namespace DnD_Battle.Creatures {
    public abstract class ACreature{
        public ACreature(string name, Spellcasting spellSlots, int _STR = 10, int _DEX = 10, int _CON = 10, int _INT = 10, int _WIS = 10, int _CHA = 10, int ac = 10,
            int baseHP = 20, int? currentHP = null, Dice? melee_attack = null, List<Effect>? _Effects = null) {

            Name = name;
            STR = new Stat(_STR, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => Count(Effects => Effects.STR));
            DEX = new Stat(_DEX, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => Count(Effects => Effects.DEX));
            CON = new Stat(_CON, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => Count(Effects => Effects.CON));
            INT = new Stat(_INT, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => Count(Effects => Effects.INT));
            WIS = new Stat(_WIS, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => Count(Effects => Effects.WIS));
            CHA = new Stat(_CHA, () => Minimum_stat_V(Effects => Effects.WIS_MIN), () => Maximum_stat_V(Effects => Effects.WIS_MAX), () => Count(Effects => Effects.CHA));
            BaseHP = baseHP;
            CurrentHP = currentHP ?? baseHP;
            SpellSlots = spellSlots;
            Melee_attack = melee_attack ?? new Dice(0, 5, 0, 0, 0, 0, 0);
            AC_Base = ac;
            if (_Effects != null) {
                Effects = _Effects;
            }
            else Effects = new List<Effect>();
        }

        public string Name { get; set; }
        public Stat STR { get; set; }
        public Stat DEX { get; set; }
        public Stat CON { get; set; }
        public Stat INT { get; set; }
        public Stat WIS { get; set; }
        public Stat CHA { get; set; }
        public abstract int BaseHP { get; set; }
        public int CurrentHP { get; set; }
        public Spellcasting SpellSlots { get; set; }
        public bool IsRaging { get; set; }
        public int AC { get { return (AC_Base + DEX.Modifier); } }
        public Dice Melee_attack { get; set; }
        public int SpellcastingModifier { get { return CHA.Modifier; } }

        public float RES_Pierce { get { return Times_V(Effects => Effects.RES_Pierce); } }
        public float RES_Blunt { get { return Times_V(Effects => Effects.RES_Blunt); } }
        public float RES_Sharp { get { return Times_V(Effects => Effects.RES_Sharp); } }
        public float RES_Heal { get { return Times_V(Effects => Effects.RES_Heal); } }
        public float RES_Acid { get { return Times_V(Effects => Effects.RES_Acid); } }
        public float RES_Cold { get { return Times_V(Effects => Effects.RES_Cold); } }
        public float RES_Fire { get { return Times_V(Effects => Effects.RES_Fire); } }
        public float RES_Force { get { return Times_V(Effects => Effects.RES_Force); } }
        public float RES_Lightning { get { return Times_V(Effects => Effects.RES_Lightning); } }
        public float RES_Necrotic { get { return Times_V(Effects => Effects.RES_Necrotic); } }
        public float RES_Poison { get { return Times_V(Effects => Effects.RES_Poison); } }
        public float RES_Psychic { get { return Times_V(Effects => Effects.RES_Psychic); } }
        public float RES_Radiant { get { return Times_V(Effects => Effects.RES_Radiant); } }
        public float RES_Thunder { get { return Times_V(Effects => Effects.RES_Thunder); } }


        public float M_RES_Pierce { get { return Times_V(Effects => Effects.M_RES_Pierce); } }
        public float M_RES_Blunt { get { return Times_V(Effects => Effects.M_RES_Blunt); } }
        public float M_RES_Sharp { get { return Times_V(Effects => Effects.M_RES_Sharp); } }
        public float M_RES_Heal { get { return Times_V(Effects => Effects.M_RES_Heal); } }
        public float M_RES_Acid { get { return Times_V(Effects => Effects.M_RES_Acid); } }
        public float M_RES_Cold { get { return Times_V(Effects => Effects.M_RES_Cold); } }
        public float M_RES_Fire { get { return Times_V(Effects => Effects.M_RES_Fire); } }
        public float M_RES_Force { get { return Times_V(Effects => Effects.M_RES_Force); } }
        public float M_RES_Lightning { get { return Times_V(Effects => Effects.M_RES_Lightning); } }
        public float M_RES_Necrotic { get { return Times_V(Effects => Effects.M_RES_Necrotic); } }
        public float M_RES_Poison { get { return Times_V(Effects => Effects.M_RES_Poison); } }
        public float M_RES_Psychic { get { return Times_V(Effects => Effects.M_RES_Psychic); } }
        public float M_RES_Radiant { get { return Times_V(Effects => Effects.M_RES_Radiant); } }
        public float M_RES_Thunder { get { return Times_V(Effects => Effects.M_RES_Thunder); } }

        public List<Effect>? Effects { get; set; } = new List<Effect>();
        private int AC_Base;
        public int baseHP_;

        private int Count(Func<Effect, int> selector) {
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
        private float Times_V(Func<Effect,float> selector) {
            float Result = 1;
            if (Effects != null) {
                foreach (Effect E in Effects) {
                    Result *= selector(E);
                }
            }
            return Result;
        }

        public void Effects_Decay() {
            if(Effects.Count >0){
                foreach (Effect E in Effects) {
                    int temp = E.Decay();
                    if (temp == 0) Effects.Remove(E);
                }
            }
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

