using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        //defining variables
        static bool testAsk = true;

        static void Main(string[] args)
        {
            //starts the play void in the game class
            Game ga = new Game();
            ga.play();

            //starts the diceRoll void in the die class
            Die dr = new Die();
            dr.diceRoll();

            while (testAsk == true)//while loop which forces users to answer yes or no and will repeat if anything else is said
            {
                //allows the user to test the classes if they would like to
                Console.WriteLine("Would you like to test the die and game classes?");
                string test = Console.ReadLine();
                if (test == "yes")
                {
                    //starts the tester void in the testing class
                    Testing te = new Testing();
                    te.tester();
                    testAsk = true;
                }
                else if (test == "no")
                {
                    Console.WriteLine("Goodbye");
                    testAsk = false;
                }
                else
                {
                    testAsk = true;
                }
            }
        }
    }
}
