using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3RandomNumGen
{
    class GuessValidator
    {

        public int randomNum { get; set; }
        public GuessValidator(int randomNum)
        {
            this.randomNum = randomNum;
        }

        public int Guesses(int guess, bool talk)
        {


            if (guess == randomNum)
            {
                if (talk)
                {
                    Console.WriteLine("You guessed the number!");
                }
                return 0;

            }
            else if (guess > randomNum)
            {
                if (guess > (randomNum + 10))
                {
                    if (talk)
                    {
                        Console.WriteLine("Your guess is WAY too high!");
                    }
                }
                else
                {
                    if (talk)
                    {
                        Console.WriteLine("Your guess is high.");
                    }
                }
                return 1;
            }
            else
            {

                if (guess < (randomNum - 10))
                {
                    if (talk)
                    {
                        Console.WriteLine("Your guess is WAY too low!");
                    }
                }
                else
                {
                    if (talk)
                    {
                        Console.WriteLine("Your guess is low.");
                    }
                }
                return -1;
            }

        }
    }
}
