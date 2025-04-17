using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using DnD_Battle.Creatures;

namespace DnD_Battle.Loaders {
    internal class Class_Loader {
        public static void ClassloadFromXML(string xml) {

            try {
                XDocument doc = XDocument.Load(xml);

                // Load Warlock Spells
                foreach (var classElement in doc.Descendants("Class")) {
                    AddClassToList(classElement);
                }
            }

            catch (FileNotFoundException) {
                Console.WriteLine($"Error: The file '{xml}' could not be found.");
            }
            catch (DirectoryNotFoundException) {
                Console.WriteLine($"Error: The directory for the file '{xml}' does not exist.");
            }
            catch (XmlException ex) {
                Console.WriteLine($"Error: The file '{xml}' is not a valid XML document. {ex.Message}");
            }
            catch (UnauthorizedAccessException) {
                Console.WriteLine($"Error: Access to the file or directory '{xml}' is denied.");
            }
            catch (Exception ex) {
                // Catch any other exceptions that might occur
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

        }

        private static void AddClassToList(XElement E) {
            if(E.Element("Name") != null && E.Element("Dice") != null) {
                int[]? spellslots = [0,0,0,0,0,0,0,0,0,0];
                if(E.Element("SpellSlots")  != null) {
                    foreach(XElement? XM in E.Descendants("SpellSlots")) {
                        if(XM.Element("Level") != null)
                            spellslots[(int)XM.Element("Level")] = (int?)XM.Element("amount") ?? 0;
                    }
                }
                int dice = int.Parse(E.Element("Dice")?.ToString());
                dice = dice / 2 + 1;
                Classes C = new Classes(E.Element("Name")?.ToString(), dice, spellslots);
            }
        }
    }
    
}
