using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle
{
    internal class DMG
    {
        public DMG(Dice heal,Dice piercing, Dice blunt, Dice slashing) {

            Heal = heal;
            Piercing = piercing;
            Blunt = blunt;
            Slashing = slashing;

            HealC = heal.Roll(true);
            PierceC = piercing.Roll(true);
            BluntC = blunt.Roll(true);
            SlashC = slashing.Roll(true);

            
        }

        public Dice Piercing { get; }
        public Dice Blunt { get; }
        public Dice Slashing { get; }
        public Dice Heal { get; }

        //gleda dali ima ikoju kocku pod tim tipom
        private int PierceC = 0;
        private int BluntC = 0;
        private int SlashC = 0;
        private int HealC = 0;


        public int Attack(Creature enemy) {
            int temp = 0;
            if (HealC != 0) {
                
                enemy.Attack( -Heal.Roll(Settings.isComplex) );
                
            }
            if (PierceC != 0) {
                temp += Piercing.Roll(Settings.isComplex);
            }
            if (BluntC != 0) {
                temp += Blunt.Roll(Settings.isComplex);
            }
            if (SlashC != 0) {
                temp += Slashing.Roll(Settings.isComplex);
            }
            enemy.Attack(temp);
            return temp;
        }

    }
}
