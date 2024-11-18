using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace DnD_Battle {
    public class SpellLoader {
        public static void LoadSpellsFromXml(string filePath) {

            try {
                XDocument doc = XDocument.Load(filePath);

                // Load Warlock Spells
                foreach (var spellElement in doc.Descendants("WarlockSpells").Descendants("Spell")) {
                    AddSpellToList(spellElement, Settings.SpellsWarlock);
                }
                // Load Wizard Spells
                foreach (var spellElement in doc.Descendants("WizardSpells").Descendants("Spell")) {
                    AddSpellToList(spellElement, Settings.SpellsWizard);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{filePath}' could not be found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Error: The directory for the file '{filePath}' does not exist.");
            }
            catch (XmlException ex)
            {
                Console.WriteLine($"Error: The file '{filePath}' is not a valid XML document. {ex.Message}");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Error: Access to the file or directory '{filePath}' is denied.");
            }
            catch (Exception ex)
            {
                // Catch any other exceptions that might occur
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

        }

        private static void AddSpellToList(XElement spellElement, List<Spells> spellList) {
            int spellSlot = int.Parse(spellElement.Element("SpellSlot").Value);
            int times = int.Parse(spellElement.Element("Times").Value);
            string name = spellElement.Element("Name").Value;
            string action = spellElement.Element("Action").Value;
            Dice heal = new Dice(
                int.Parse(spellElement.Element("Heal").Element("D1").Value),
                int.Parse(spellElement.Element("Heal").Element("D4").Value),
                int.Parse(spellElement.Element("Heal").Element("D6").Value),
                int.Parse(spellElement.Element("Heal").Element("D8").Value),
                int.Parse(spellElement.Element("Heal").Element("D10").Value),
                int.Parse(spellElement.Element("Heal").Element("D12").Value),
                int.Parse(spellElement.Element("Heal").Element("D20").Value)
            );

            Dice piercing = new Dice(
                int.Parse(spellElement.Element("Piercing").Element("D1").Value),
                int.Parse(spellElement.Element("Piercing").Element("D4").Value),
                int.Parse(spellElement.Element("Piercing").Element("D6").Value),
                int.Parse(spellElement.Element("Piercing").Element("D8").Value),
                int.Parse(spellElement.Element("Piercing").Element("D10").Value),
                int.Parse(spellElement.Element("Piercing").Element("D12").Value),
                int.Parse(spellElement.Element("Piercing").Element("D20").Value)
            );

            Dice blunt = new Dice(
                int.Parse(spellElement.Element("Blunt").Element("D1").Value),
                int.Parse(spellElement.Element("Blunt").Element("D4").Value),
                int.Parse(spellElement.Element("Blunt").Element("D6").Value),
                int.Parse(spellElement.Element("Blunt").Element("D8").Value),
                int.Parse(spellElement.Element("Blunt").Element("D10").Value),
                int.Parse(spellElement.Element("Blunt").Element("D12").Value),
                int.Parse(spellElement.Element("Blunt").Element("D20").Value)
            );

            Dice slashing = new Dice(
                int.Parse(spellElement.Element("Slashing").Element("D1").Value),
                int.Parse(spellElement.Element("Slashing").Element("D4").Value),
                int.Parse(spellElement.Element("Slashing").Element("D6").Value),
                int.Parse(spellElement.Element("Slashing").Element("D8").Value),
                int.Parse(spellElement.Element("Slashing").Element("D10").Value),
                int.Parse(spellElement.Element("Slashing").Element("D12").Value),
                int.Parse(spellElement.Element("Slashing").Element("D20").Value)
            );

            // Create the Spells object and add it to the respective list
            Spells spell = new Spells(name,spellSlot, times, action, heal, piercing, blunt, slashing);
            spellList.Add(spell);
        }
    }
}