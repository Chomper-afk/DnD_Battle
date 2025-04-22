using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle.Spell_Stuff {
    public class Leveling_rule {
        public int Times { get; set; }
        public List<int> Times_Steps { get; set; }

        public DMG DMGPerLevelStep { get; set; }
        public List<int> DMG_Steps {  get; set; }

        public DMG DMGPerSpellSlot { get; set; }
        public int SpellSlot_Steps { get; set; }

        public Leveling_rule(int _Times = 0, int[]? _Times_Steps = null, DMG? _DMG = null, int[]? _DMGSteps = null, DMG? _SpellSlot = null, int _SSSteps = 0) {
            Times = _Times;
            Times_Steps = new List<int>();
            if(_Times_Steps != null) {
                foreach(int _Step in _Times_Steps) {
                    Times_Steps.Add(_Step);
                    }
                }
            DMGPerLevelStep = _DMG ?? new DMG();

            DMG_Steps = new List<int>();
            if(_DMGSteps != null) {
                foreach (int _Step in _DMGSteps) { DMG_Steps.Add(_Step); }
                }

            DMGPerSpellSlot = _SpellSlot ?? new DMG();
            SpellSlot_Steps = _SSSteps;

            }


        }
    }
