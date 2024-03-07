using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //defining variables
        public int dieNum;
        static bool again = false;
        static bool wrong = false;
        Random rnd = new Random();

        public void diceRoll()
        {
            while (again == false)//while loop which allows users to reroll the die
            {
                wrong = false;
                dieNum = rnd.Next(1, 6);//random-ish number generator for the die
                Console.WriteLine("The die  from die class = " + dieNum);
                while (wrong == false)//while loop which forces users to answer yes or no and will repeat if anything else is said
                {
                    Console.WriteLine("Would you like to roll the die again?");
                    string roll = Console.ReadLine();

                    //if no then the program continues
                    if (roll == "no")
                    {
                        again = true;
                        wrong = true;
                    }

                    //if yes then the die rerolls
                    else if (roll == "yes")
                    {
                        Console.WriteLine("Rolling die...");
                        wrong = true;
                    }

                    //loop repeats for any other answer
                    else
                    {
                        Console.WriteLine("Please enter yes or no");
                        wrong = false;
                    }
                }
            }
        }
    }
}
