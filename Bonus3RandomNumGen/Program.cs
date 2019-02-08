using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3RandomNumGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            Random random = new Random();
            int gamesToRun = 0;
            int attempts = 0;
            bool again = true;
            while (again)
            {
                bool validNumber = true;
                while (validNumber)
                {
                    Console.WriteLine("How many games would you like to run?");

                    bool userInput = int.TryParse(Console.ReadLine(), out gamesToRun);
                    if (userInput == false || gamesToRun <= 0)
                    {
                        Console.WriteLine("Please enter in a valid positive integer");
                    }
                    else
                    {
                        validNumber = false;
                    }
                }
                RandomGuesser rg = new RandomGuesser(random);
                BruteForce bfg = new BruteForce();
                HigherOrLower hol = new HigherOrLower(random);
                BinarySearch bs = new BinarySearch();


                while (gamesToRun > 0)
                {
                    int randomNum = random.Next(1, 101);

                    rg.randomNum = randomNum;
                    rg.Game();

                    bfg.randomNum = randomNum;
                    bfg.Game();

                    hol.randomNum = randomNum;
                    hol.Game();

                    bs.randomNum = randomNum;
                    bs.Game();
                    gamesToRun--;
                }

                PrintResults(rg.GameResults, "Random Guesser");
                PrintResults(bfg.GameResults, "Brute Force");
                PrintResults(hol.GameResults, "Higher Or Lower");
                PrintResults(bs.GameResults, "Binary Search");

                Console.WriteLine("======This is a batch run.======");
                RandomGuesser rg2 = new RandomGuesser(random);
                BruteForce bfg2 = new BruteForce();
                HigherOrLower hol2 = new HigherOrLower(random);
                BinarySearch bs2 = new BinarySearch();
                gamesToRun = 100;
                while (gamesToRun > 0)
                {
                    int randomNum = gamesToRun;

                    rg2.randomNum = randomNum;
                    rg2.Game();

                    bfg2.randomNum = randomNum;
                    bfg2.Game();

                    hol2.randomNum = randomNum;
                    hol2.Game();

                    bs2.randomNum = randomNum;
                    bs2.Game();
                    gamesToRun--;
                }


                PrintResults(rg2.GameResults, "Random Guesser");
                PrintResults(bfg2.GameResults, "Brute Force");
                PrintResults(hol2.GameResults, "Higher Or Lower");
                PrintResults(bs2.GameResults, "Binary Search");
                again = Continue();
            }

            

        }

        public static void PrintResults(List<int> GameResults, string GameTitle)
        {

            int best = GameResults.Min();
            int worst = GameResults.Max();
            double average = GameResults.Average();
            Console.WriteLine(GameTitle + " results");
            Console.WriteLine("Best attempt: " + best);
            Console.WriteLine("Worst attempt: " + worst);
            Console.WriteLine("Average attempts: " + average);
            Console.WriteLine();
        }
        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Would you like to Continue (y/n): ");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "y")
            {
                run = true;
            }
            else if (userAnswer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, I did not understand, please try again");
                return Continue();
            }
            return run;
        }

    }
}
