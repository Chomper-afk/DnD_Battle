using DnD_Battle.Spell_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace DnD_Battle.Loaders {
    internal class DMG_Loader {

        public static DMG Load(XElement DMG_XML) {

#pragma warning disable CS8604 // Possible null reference argument.
            return new DMG(

                Dice_Loader.Load(DMG_XML.Element("Heal")),
                Dice_Loader.Load(DMG_XML.Element("Pierce")),
                Dice_Loader.Load(DMG_XML.Element("Blunt")),
                Dice_Loader.Load(DMG_XML.Element("Slash")),
                Dice_Loader.Load(DMG_XML.Element("Acid")),
                Dice_Loader.Load(DMG_XML.Element("Cold")),
                Dice_Loader.Load(DMG_XML.Element("Fire")),
                Dice_Loader.Load(DMG_XML.Element("Force")),
                Dice_Loader.Load(DMG_XML.Element("Lighting")),
                Dice_Loader.Load(DMG_XML.Element("Necrotic")),
                Dice_Loader.Load(DMG_XML.Element("Posion")),
                Dice_Loader.Load(DMG_XML.Element("Psychic")),
                Dice_Loader.Load(DMG_XML.Element("Radiant")),
                Dice_Loader.Load(DMG_XML.Element("Thunder"))

                );
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }
}
