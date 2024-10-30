using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Battle
{
    internal class Dice
    {
        public int D1 { get; set; }
        public int D4 { get; set; }
        public int D6 { get; set; }
        public int D8 { get; set; }
        public int D10 { get; set; }
        public int D12 { get; set; }
        public int D20 { get; set; }

        /// <summary>
        /// Initializes a new instance of the Dice class with the specified quantities of different dice types.
        /// </summary>
        /// <param name="d1">Flat bonus to rolls.</param>
        /// <param name="d4">The number of 4-sided dice.</param>
        /// <param name="d6">The number of 6-sided dice.</param>
        /// <param name="d8">The number of 8-sided dice.</param>
        /// <param name="d10">The number of 10-sided dice.</param>
        /// <param name="d12">The number of 12-sided dice.</param>
        /// <param name="d20">The number of 20-sided dice.</param>
        public Dice(int d1 = 0, int d4 = 0, int d6 = 0, int d8 = 0, int d10 = 0, int d12 = 0, int d20 = 0) { 
            D1 = d1;
            D4 = d4;
            D6 = d6;
            D8 = d8;
            D10 = d10;
            D12 = d12;
            D20 = d20;

        }
        Random r = new Random(Guid.NewGuid().GetHashCode());

        /// <summary>
        /// Rolls all dices.
        /// </summary>
        /// <param name="isComplex"> True => number of dice*one roll, False => each dice sepretly rolled</param>
        /// <param name="modifier">flat bonus</param>
        /// <returns></returns>
        public int Roll( bool isComplex, int modifier = 0)
        {
            if (isComplex)
            {
                int temp = 0;

                temp += D1;
                temp += D4 * r.Next(1, 4 + 1);
                temp += D6 * r.Next(1, 6 + 1);
                temp += D8 * r.Next(1, 8 + 1);
                temp += D10 * r.Next(1, 10 + 1);
                temp += D12 * r.Next(1, 12 + 1);
                temp += D20 * r.Next(1, 20 + 1);
                temp += modifier;

                return temp;
            }
            else
            {
                int temp = 0;
                temp += D1;
                temp += Rolling(4, D4);
                temp += Rolling(6, D6);
                temp += Rolling(8, D8);
                temp += Rolling(10, D10);
                temp += Rolling(12, D12);
                temp += Rolling(20, D20);
                return temp;
            }
        }

        /// <summary>
        /// Roll a dice
        /// </summary>
        /// <param name="Sides">How many options</param>
        /// <param name="Count">How many times</param>
        /// <returns></returns>
        public static int Rolling(int Sides, int Count)
        {
            int temp = 0;
            for (int i = 0; i < Count; i++) {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                temp += r.Next(1, Sides + 1);
            }
            return temp;
        }
    }
}
