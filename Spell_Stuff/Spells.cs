using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Battle.Creatures;

namespace DnD_Battle.Spell_Stuff {
    internal class Spells : DMG {

        public Spells(string name, int spellSlot, int times, string action, DMG _DMG) : base(_DMG) {
            SpellSlot = spellSlot;
            Times = times;
            Name = name;
            switch (action) {
                case "A":
                    Action = 1;
                    break;
                case "B":
                    Action = 2;
                    break;
            }
            Action_txt = action;
        }
        public Spells(string name, int spellSlot, int times, string action, Dice? heal = null, Dice? piercing = null, Dice? blunt = null, Dice? slashing = null, Dice? acid = null, Dice? cold = null,
        Dice? fire = null, Dice? force = null, Dice? lightning = null, Dice? necrotic = null, Dice? poison = null, Dice? psychic = null, Dice? radiant = null, Dice? thunder = null) : 
        base(heal, piercing, blunt, slashing, acid, cold, fire, force, lightning, necrotic, poison, psychic, radiant, thunder) {

            SpellSlot = spellSlot;
            Times = times;
            Name = name;
            switch (action) {
                case "A":
                    Action = 1;
                    break;
                case "B":
                    Action = 2;
                    break;
            }
            Action_txt = action;
        }


        public string Name { get; }
        public int SpellSlot { get; }
        public int Action { get; }
        private string Action_txt { get; set; }
        public int Times;

        public void Attack(ACreature P1, ACreature enemy) {
            int temp;
            if (P1.SpellSlots.SpellSlots[SpellSlot] > 0 || SpellSlot == 0) {
                if (!(Action == 1 && Settings.Actions <= 0 || Action == 2 && Settings.B_Actions <= 0)) {
                    P1.SpellSlots.SpellSlots[SpellSlot]--;
                    switch (Action) {
                        case 1:
                            Settings.Actions--;
                            break;
                        case 2:
                            Settings.B_Actions--;
                            break;
                    }
                    for (int i = 0; i < Times; i++) {
                        if (Dice.Rolling(20, 1) + P1.SpellcastingModifier > enemy.AC) {
                            temp = Attack(enemy);
                            enemy.CurrentHP -= P1.SpellcastingModifier;
                            Settings.Log += "\r\n" + P1.Name + " hits " + enemy.Name + "for a total of " + (temp + P1.SpellcastingModifier) + "DMG";
                        }
                        else {
                            Settings.Log += "\r\n" + P1.Name + " missed " + (i + 1) + ". attack with " + Name;
                            Console.WriteLine("you miss");
                        }

                    }

                }
                else {
                    Console.WriteLine("Missing actions");
                    Settings.Log += "\r\nYou are missing Action/Bonus Action";
                }
            }
            else {
                Settings.Log += "\r\n" + P1.Name + " doesnt have enough spell slots of level " + SpellSlot;
                Console.WriteLine("Not enough Spell Slots");
            }
        }
        string element_output(Dice outputting) {
            string s = "";
            s += outputting.D4 + "D4 + " + outputting.D6 + "D6 + " + outputting.D8 + "D8 + " + outputting.D10 + "D10 + " + outputting.D12 + "D12 + " + outputting.D20 + "D20 + " + outputting.D1 + "\r\n";
            return s;
        }

        public override string ToString() {
            string s = "2";

            s = Name + "\r\nSpellslot: " + SpellSlot + "\r\nTimes: " + Times + "\r\nAction/Bonus Action: " + Action_txt + "\r\n";
            s += "Blunt = " + element_output(Blunt) + "Slashing = " + element_output(Slash);
            s += "Piercing = " + element_output(Pierce);
            return s;
        }

    }
}
