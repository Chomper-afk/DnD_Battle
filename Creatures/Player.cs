using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Battle.Creatures.Gear_Stuff;
using DnD_Battle.Spell_Stuff;

namespace DnD_Battle.Creatures {
    internal class Player : ACreature {
        public Player(string name, Spellcasting spellSlots, int _STR = 10, int _DEX = 10, int _CON = 10, int _INT = 10, int _WIS = 10, int _CHA = 10, int ac = 10,
            int baseHP = 20, int currentHP = 20, Dice? melee_attack = null, List<Effect>? _Effects = null, List<Classes>? _Classes = null) : base(name, spellSlots, _STR, _DEX, _CON, _INT, _WIS, _CHA, ac, baseHP,
            currentHP, melee_attack, _Effects) {
            if (_Classes != null) Classes = _Classes;
            else Classes = new List<Classes>();

            var list = new Dictionary<string,int>();

            foreach(Classes C in Classes) {
                if (!list.ContainsKey(C.Name)) {
                    list.Add(C.Name, 0);
                    }

                }

            }
        
        

        public List<Classes> Classes;

        public List<Spells> Known_Spells = new List<Spells>();
        public List<AItems> Items = new List<AItems>();

        public override int BaseHP {
            get { 
                int temp = baseHP_;
                if (Classes.Count > 0) { 
                    temp = 0;
                    foreach (Classes C in Classes) {
                        temp += C.HitDice + CON.Modifier; 
                    } 
                } 
                return temp; 
            } 
            set => baseHP_ = value;
        }

    }
}
