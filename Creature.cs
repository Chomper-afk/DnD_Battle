using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    internal class Creature {

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
        public Creature(string name, Spellcasting spellSlots, int sTR = 10, int dEX = 10, int cON = 10, int iNT = 10, int wIS = 10, int cHA = 10,int ac = 10, int baseHP = 4, Dice? melee_attack = null) {
            Name = name;
            STR = sTR;
            DEX = dEX;
            CON = cON;
            INT = iNT;
            WIS = wIS;
            CHA = cHA;
            AC = ac;
            BaseHP = baseHP;
            CurrentHP = baseHP;
            SpellSlots = spellSlots;
            Melee_attack = melee_attack ?? new Dice(0, 1, 0, 0, 0, 0, 0);
            STR_Modifier  = (STR-10)/2;
            DEX_Modifier  = (DEX-10)/2;
            CON_Modifier  = (CON-10)/2;
            INT_Modifier  = (INT-10)/2;
            WIS_Modifier  = (WIS-10)/2;
            CHA_Modifier = (CHA-10) / 2;
        }

        public string Name { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON {  get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA {  get; set; }
        public int BaseHP { get; set; }
        public int CurrentHP { get; set; }
        public Spellcasting SpellSlots { get; set; }
        public bool IsRaging { get; set; } = false;
        public int AC { get; set; }
        public Dice Melee_attack { get; set; }
        public int STR_Modifier { get; set; }
        public int DEX_Modifier { get; set; }
        public int CON_Modifier { get; set; }
        public int INT_Modifier { get; set; }
        public int WIS_Modifier { get; set; }
        public int CHA_Modifier { get; set; }


        public void Attack(int dmg) {
            CurrentHP -= dmg;
            if (CurrentHP < 0) {
                CurrentHP = 0;
                Console.WriteLine(Name + " has died!!");
                Settings.log += "\r\n" + Name + " has died";
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
