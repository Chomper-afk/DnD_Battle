﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle {
    static class Settings {

        public static bool isComplex = false;

        public static int Actions { get; set; } = 1;
        public static int B_Actions { get; set; } = 1;


        public static string Path = Directory.GetCurrentDirectory() + "\\Test";
        public static List<Spells> SpellsWarlock {  get; set; } = new List<Spells>();

        public static Player User { get; set; } = new Player("Chomper", new Spellcasting(new int[10] {5,5,5,5,5,5,5,5,5,5} ));

        public static string log { get; set; } = "";


    }
}
