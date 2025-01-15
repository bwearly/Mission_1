using System;

namespace DiceRollingSimulator

{
    class DiceRollingSimulator
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the dice throwing simulator!");
            System.Console.Write("How many dice rolls would you like to simulate? ");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int numberOfRolls) && numberOfRolls > 0)
            {
                Console.WriteLine($"\nYou chose to simulate {numberOfRolls} dice rolls.");

                int[] rollResults = DiceRollingSimulator.SimulateRolls(numberOfRolls);

                Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
                Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
                Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

                for (int diceSum = 2; diceSum <= 12; diceSum++)
                {
                    int percentage = (int)Math.Round((double)rollResults[diceSum] / numberOfRolls * 100);
                    Console.WriteLine($"{diceSum}: {new string('*', percentage)}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive whole number.");
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }

        public static int[] SimulateRolls(int numDiceRolls)
        {
            int[] rollsCount = new int[13];

            Random random = new Random();

            for (int i = 0; i < numDiceRolls; i++)
            {
                int dice1 = random.Next(1,7);
                int dice2 = random.Next(1, 7);
                int diceSum = dice1 + dice2;

                rollsCount[diceSum]++;
            }

            return rollsCount;
        }


    }
}

