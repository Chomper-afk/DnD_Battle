using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DnD_Battle.Spell_Stuff;
using DnD_Battle.Creatures;
using DnD_Battle.Loaders;
using DnD_Battle.Creatures.Gear_Stuff;

namespace DnD_Battle {
    static class Settings {



        public static bool isComplex = false;

        public static int Actions { get; set; } = 1;
        public static int B_Actions { get; set; } = 1;


        public static string Path = Directory.GetCurrentDirectory() + "\\Test";
        public static List<Spells> SpellsWarlock {  get; set; } = new List<Spells>();
        public static List<Spells> SpellsWizard { get; set; } = new List<Spells>();

        public static List<Classes> Classes {  get; set; }


        public static int Stat_MIN { get; set; } = 0;
        public static int Stat_MAX { get; set; } = 100;
        
        public static Player User { get; set; } = new Player("Chomper", new Spellcasting([5, 5, 5, 5, 5, 5, 5, 5, 5, 5]));

        public static string Log { get; set; } = "";

        public static void Initialize() {
            foreach (string file in Directory.GetFiles(Path)) {
                SpellLoader.LoadSpellsFromXml(file);
                }
            foreach(Spells S  in SpellsWarlock) {
                User.Known_Spells.Add(S.Clone());
            }

            User.Items.Add(new Potions("test", "This is test item, if you see this its ether early in dev or something got messed up", 2));
            User.Items.Add(new Potions("test2", "This is test2 item, if you see this its ether early in dev or something got messed up", 3,2));
            User.Items.Add(new Potions("test3", "This is test3 item, if you see this its ether early in dev or something got messed up", 4));
            User.Items.Add(new Potions("Boost", "Booster, gives +1 in every stat", 100,1,new Effect("Booster",3,1,1,1,1,1,1)));

        }

    }
}
