using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    static class Settings {

        public static bool isComplex = false;

        public static int Actions { get; set; } = 1;
        public static int B_Actions { get; set; } = 1;


        public static string Path = Directory.GetCurrentDirectory() + "\\Test";
        public static List<Spells> SpellsWarlock {  get; set; } = new List<Spells>();
        public static List<Spells> SpellsWizard { get; set; } = new List<Spells>();

        public static int Stat_MIN { get; set; } = 0;
        public static int Stat_MAX { get; set; } = 100;
        
        public static Player User { get; set; } = new Player("Chomper", new Spellcasting([5,5,5,5,5,5,5,5,5,5] ));

        public static string Log { get; set; } = "";

    }
}
