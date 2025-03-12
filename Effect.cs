using DnD_Battle.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    public class Effect {

        public string Name { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON { get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        public int STR_MIN { get; set; } = Settings.Stat_MIN;
        public int DEX_MIN { get; set; } = Settings.Stat_MIN;
        public int CON_MIN { get; set; } = Settings.Stat_MIN;
        public int INT_MIN { get; set; } = Settings.Stat_MIN;
        public int WIS_MIN { get; set; } = Settings.Stat_MIN;
        public int CHA_MIN { get; set; } = Settings.Stat_MIN;
        public int STR_MAX { get; set; } = Settings.Stat_MAX;
        public int DEX_MAX { get; set; } = Settings.Stat_MAX;
        public int CON_MAX { get; set; } = Settings.Stat_MAX;
        public int INT_MAX { get; set; } = Settings.Stat_MAX;
        public int WIS_MAX { get; set; } = Settings.Stat_MAX;
        public int CHA_MAX { get; set; } = Settings.Stat_MAX;
        public float RES_Pierce { get; set; } = 1;
        public float RES_Blunt { get; set; } = 1;
        public float RES_Sharp { get; set; } = 1;
        public float RES_Heal { get; set; } = 1;
        public float RES_Acid { get; set; } = 1;
        public float RES_Cold { get; set; } = 1;
        public float RES_Fire { get; set; } = 1;
        public float RES_Force { get; set; } = 1;
        public float RES_Lightning { get; set; } = 1;
        public float RES_Necrotic { get; set; } = 1;
        public float RES_Poison { get; set; } = 1;
        public float RES_Psychic { get; set; } = 1;
        public float RES_Radiant { get; set; } = 1;
        public float RES_Thunder { get; set; } = 1;


        public float M_RES_Pierce { get; set; } = 1;
        public float M_RES_Blunt { get; set; } = 1;
        public float M_RES_Sharp { get; set; } = 1;
        public float M_RES_Heal { get; set; } = 1;
        public float M_RES_Acid { get; set; } = 1;
        public float M_RES_Cold { get; set; } = 1;
        public float M_RES_Fire { get; set; } = 1;
        public float M_RES_Force { get; set; } = 1;
        public float M_RES_Lightning { get; set; } = 1;
        public float M_RES_Necrotic { get; set; } = 1;
        public float M_RES_Poison { get; set; } = 1;
        public float M_RES_Psychic { get; set; } = 1;
        public float M_RES_Radiant { get; set; } = 1;
        public float M_RES_Thunder { get; set; } = 1;

        public int Counter { get; set; }

        public Effect(Effect _Effect) {
            foreach (PropertyInfo property in typeof(Creature).GetProperties()) {
                property.SetValue(this, property.GetValue(_Effect));
            }
        }
        public Effect(string _Name, int _Counter = -1, int _STR = 0, int _DEX = 0, int _CON = 0, int _INT = 0, int _WIS = 0, int _CHA = 0) {
            Name = _Name;
            Counter = _Counter;
            STR = _STR;
            DEX = _DEX;
            CON = _CON;
            INT = _INT;
            WIS = _WIS;
            CHA = _CHA;
        }

        /// <summary>
        /// Decays effect
        /// returns 0 if time has run out |
        /// returns 1 if there is still time |
        /// returns -1 if it doesn't decay
        /// </summary>
        /// <returns></returns>
        public int Decay() {
            if (Counter >= 0) {
                Counter--;
                if (Counter == 0) return 0;
                return 1;
            }
            return -1;
        }
        public override string ToString() {
            string s = Name + "\r\n"
                + "Stat change: \r\n";
            string temp = s;
            if (STR > 0) s += "STR +" + STR + "\r\n";
            if (STR < 0) s += "STR "  + STR + "\r\n";
            if (DEX > 0) s += "DEX +" + DEX + "\r\n";
            if (DEX < 0) s += "DEX "  + DEX + "\r\n";
            if (CON > 0) s += "CON +" + CON + "\r\n";
            if (CON < 0) s += "CON "  + CON + "\r\n";
            if (INT > 0) s += "INT +" + INT + "\r\n";
            if (INT < 0) s += "INT "  + INT + "\r\n";
            if (WIS > 0) s += "WIS +" + WIS + "\r\n";
            if (WIS < 0) s += "WIS "  + WIS + "\r\n";
            if (CHA > 0) s += "CHA +" + CHA + "\r\n";
            if (CHA < 0) s += "CHA "  + CHA + "\r\n";

            if(temp == s) s += "No stat change\r\n";

            s += "\r\nDMG muplipliers:\r\n";
            temp = s;
            if(RES_Sharp != 1) s += "Slashing multiplier: " + 1 / RES_Sharp + "\r\n";
            if(RES_Blunt != 1) s += "Bludgoning muliplier: " + 1 / RES_Blunt + "\r\n";
            if(RES_Pierce != 1) s += "Piercing multiplier: " + 1 / RES_Pierce + "\r\n";
            if (RES_Heal != 1) s += "Healing multiplier: " + 1 / RES_Heal + "\r\n";

            if(temp == s) s += "No DMG multipliers";

            return s;
        }

    }
}
