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
            int[] rollsCount = new int[13];

            Random random = new Random();

            for (int i = 0; i < numDiceRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int diceSum = dice1 + dice2;

                rollsCount[diceSum]++;
            }

            return rollsCount;
        }
    }
}
