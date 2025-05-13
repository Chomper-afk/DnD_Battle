using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Battle.Creatures;

namespace DnD_Battle.Spell_Stuff {
    public class Spells : DMG {

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

        public Leveling_rule Change {  get; set; } = new Leveling_rule();
        public string Name { get; }
        public int SpellSlot { get; }
        public int Action { get; }
        private string Action_txt { get; set; }
        public int Times { get; set; }

        public void Attack(ACreature P1, ACreature enemy, int? ss = null) {
            int temp;
            int temp_Level = P1.Classes_.Count;
            int times_Extra = 0;
            int Temp_Attack = 0;
            int ss_Times = 0;
            if(ss == null)
                ss = SpellSlot;

            if (Change.SpellSlot_Steps != 0) {
                for (int? i = SpellSlot; i < ss; i += Change.SpellSlot_Steps) {
                    ss_Times++;
                    }
                }

            foreach (int I in Change.Times_Steps) {
                if (I <= temp_Level)
                    times_Extra++;
                }

            foreach(int I in Change.DMG_Steps) {
                if(I <=temp_Level)
                    Temp_Attack++;
                }

            if (P1.SpellSlots.SpellSlots[(int)ss] > 0 || SpellSlot == 0) {
                if (!(Action == 1 && Settings.Actions <= 0 || Action == 2 && Settings.B_Actions <= 0)) {
                    P1.SpellSlots.SpellSlots[(int)ss]--;
                    switch (Action) {
                        case 1:
                            Settings.Actions--;
                            break;
                        case 2:
                            Settings.B_Actions--;
                            break;
                    }
                    for (int i = 0; i < Times + times_Extra; i++) {
                        if (Dice.Rolling(20, 1) + P1.SpellcastingModifier >= enemy.AC) {
                            temp = Attack(enemy);
                            for (int j = 0; j < Temp_Attack; j++) {
                                temp += Change.DMGPerLevelStep.Attack(enemy);
                                }
                            for(int j = 0; j < ss_Times; j++) {
                                temp += Change.DMGPerSpellSlot.Attack(enemy);
                                }

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
                Settings.Log += "\r\n" + P1.Name + " doesnt have enough spell slots of level " + ss;
                Console.WriteLine("Not enough Spell Slots");
            }
        }
        public Spells Clone() {
            return new Spells(
                name: this.Name,
                spellSlot: this.SpellSlot,
                times: this.Times,
                action: this.Action_txt,
                heal: this.Heal,
                piercing: this.Pierce,
                blunt: this.Blunt,
                slashing: this.Slash,
                acid: this.Acid,
                cold: this.Cold,
                fire: this.Fire,
                force: this.Force,
                lightning: this.Lightning,
                necrotic: this.Necrotic,
                poison: this.Poison,
                psychic: this.Psychic,
                radiant: this.Radiant,
                thunder: this.Thunder
            );
        }


        public override string ToString() {
            return Action_txt + "|" + Name;
        }

    }
}
