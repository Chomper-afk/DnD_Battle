using System;
using System.Collections.Generic;
using System.Linq;
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
        public float RES_Pierce {  get; set; }
        public float RES_Blunt { get; set; }
        public float RES_Sharp {  get; set; }
        public float RES_Heal { get; set; }
        public Effect(string _Name, int _STR = 0, int _DEX = 0, int _CON = 0, int _INT = 0, int _WIS = 0, int _CHA = 0,
            float _RES_Pierce = 1, float _RES_Blunt = 1, float _RES_Sharp = 1, float _RES_Heal = 1) {
            Name = _Name;
            STR = _STR;
            DEX = _DEX;
            CON = _CON;
            INT = _INT;
            WIS = _WIS;
            CHA = _CHA;
            RES_Pierce = _RES_Pierce;
            RES_Blunt = _RES_Blunt;
            RES_Sharp = _RES_Sharp;
            RES_Heal = _RES_Heal;
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
