using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DnD_Battle.Loaders {
    internal static class Dice_Loader {
        static public Dice Load(XElement Dice_XML) {
            if (Dice_XML == null) {
                return new Dice();
            }
            Dice DICE = new Dice(
                    int.Parse(Dice_XML?.Element("D1")?.Value ?? "0"),
                    int.Parse(Dice_XML?.Element("D4")?.Value ?? "0"),
                    int.Parse(Dice_XML?.Element("D6")?.Value ?? "0"),
                    int.Parse(Dice_XML?.Element("D8")?.Value ?? "0"),
                    int.Parse(Dice_XML?.Element("D10")?.Value ?? "0"),
                    int.Parse(Dice_XML?.Element("D12")?.Value ?? "0"),
                    int.Parse(Dice_XML?.Element("D20")?.Value ?? "0")
                );
            return DICE;
        }
    }
}
