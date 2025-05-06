using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using DnD_Battle.Spell_Stuff;

namespace DnD_Battle.Loaders {
    public class SpellLoader {
        public static void LoadSpellsFromXml(string filePath) {

            try 
                {
                XDocument doc = XDocument.Load(filePath);


                foreach (var spellElement in doc.Descendants("Spell")) {
                    AddSpellToList(spellElement);
                }
            }
            
            catch (FileNotFoundException) {
                Console.WriteLine($"Error: The file '{filePath}' could not be found.");
            }
            catch (DirectoryNotFoundException) {
                Console.WriteLine($"Error: The directory for the file '{filePath}' does not exist.");
            }
            catch (XmlException ex) {
                Console.WriteLine($"Error: The file '{filePath}' is not a valid XML document. {ex.Message}");
            }
            catch (UnauthorizedAccessException) {
                Console.WriteLine($"Error: Access to the file or directory '{filePath}' is denied.");
            }
            catch (Exception ex) {
                // Catch any other exceptions that might occur
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
           
        }

        private static void AddSpellToList(XElement spellElement) {
            if (new[] { "SpellSlot", "Name", "Times", "Action" }.Any(e => spellElement.Element(e) != null)) {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                int spellSlot = int.Parse(spellElement.Element("SpellSlot").Value);
                int times = int.Parse(spellElement.Element("Times").Value);
                string name = spellElement.Element("Name").Value;
                string action = spellElement.Element("Action").Value;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

#pragma warning disable CS8604 // Possible null reference argument.
                DMG _DMG = DMG_Loader.Load(spellElement.Element("DMG")) ?? new DMG();
#pragma warning restore CS8604 // Possible null reference argument.

                // Create the Spells object and add it to the respective list
                Spells spell = new Spells(name, spellSlot, times, action, _DMG);
                foreach(XElement E in spellElement.Descendants("Class").Descendants("S")) {
                    switch (E.Value) {
                        case "Warlock":
                            Settings.SpellsWarlock.Add(spell);
                            break;
                        case "Wizard":
                            Settings.SpellsWizard.Add(spell);
                            break;
                        default:
                            throw new Exception("unkonw spell class");
                    }
                }
            }
            

        }
    }
}