using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateRollClass
{
    internal class RollClass
    {
        public static int[] SimulateRolls(int numDiceRolls)
        {
            // Creates an integer array to house the number of rolls
            int[] rollsCount = new int[13];

            // Pulls in the random number generatator class
            Random random = new Random();

            // Based on the number of rolls, the dice will roll which will collect the results in an array
            for (int i = 0; i < numDiceRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int diceSum = dice1 + dice2;

                rollsCount[diceSum]++;
            }
            // Array is passed to the other class
            return rollsCount;
        }
    }
}
