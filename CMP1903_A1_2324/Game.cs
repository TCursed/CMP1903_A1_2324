using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //defining variables
        public int totalG;
        public int die1;
        public int die2;
        public int die3;
        static Random rnd = new Random();
        bool spin = false;
        bool incorrect = false;

        public void play()
        {
            while (spin == false)//while loop which allows users to reroll the dice
            {
                //random-ish dice rolls between 1 and 6
                die1 = rnd.Next(1, 6);
                die2 = rnd.Next(1, 6);
                die3 = rnd.Next(1, 6);
                totalG = die1 + die2 + die3; //adds the random dice rolls to get a total
                
                //displays the different numbers gotten from each die and the sum
                Console.WriteLine("Die1 from game class = " + die1);
                Console.WriteLine("Die2 from game class = " + die2);
                Console.WriteLine("Die3 from game class = " + die3);
                Console.WriteLine("Total from game class = " + totalG);

                incorrect = false;
                while (incorrect == false) //while loop which forces users to answer yes or no and will repeat if anything else is said
                {
                    Console.WriteLine("Would you like to reroll the three dice?");
                    string response = Console.ReadLine();

                    //if yes the dice rerolls
                    if (response == "yes")
                    {
                        spin = false;
                        incorrect = true;
                        Console.WriteLine("Rerolling dice...");
                    }

                    //if no then the program continues
                    else if (response == "no")
                    {
                        spin = true;
                        incorrect = true;
                    }
                    
                    //loop repeats for any other answer
                    else
                    {
                        Console.WriteLine("Please enter yes or no");
                        incorrect = false;
                    }                   
                }
            }
        }
    }
}
