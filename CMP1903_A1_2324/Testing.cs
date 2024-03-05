using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        //defining variables
        bool pass = false;
        bool testAgain = true;
        bool ask = true;

        public void tester()
        {
            var gameDie = new Game();
            while (testAgain == true) //while loop to allow users to test multiple classes or multiple results from classes
            {
                //gives the user the choice of which class they would like to test
                Console.WriteLine("Which class would you like to test die or game");
                string classTest = Console.ReadLine();

                if (classTest == "game")//will test the game class
                {
                    //asks the user for the dice results to allow the user to choose which set of rolls they would like to test
                    Console.WriteLine("Enter the three numbers from the total you would like to test");
                    Console.WriteLine("Die 1");
                    string die1ToTest = Console.ReadLine();
                    int die1Test = int.Parse(die1ToTest); //converts the string inputed into an integer

                    Console.WriteLine("Die 2");
                    string die2ToTest = Console.ReadLine();
                    int die2Test = int.Parse(die2ToTest); 

                    Console.WriteLine("Die 3");
                    string die3ToTest = Console.ReadLine();
                    int die3Test = int.Parse(die3ToTest);

                    int totalFin = die1Test + die2Test + die3Test; //adds the values input together
                    Console.WriteLine("Was this your total? " + totalFin); //asks the user if the total show now is the same as the total being tested
                    string totalCorrect = Console.ReadLine();

                    if (totalCorrect == "yes")
                    {
                        Console.WriteLine("The game class is functioning correctly");
                    }

                    else if (totalCorrect == "no")
                    {
                        Console.WriteLine("The game class in not functioning correctly");
                    }
                }

                else if (classTest == "die")//will test the die class
                {
                    //asks the user if they got a result not between 1-6
                    Console.WriteLine("Did you get a number above 6 or below 1?");
                    string correctDie = Console.ReadLine();
                    
                    if (correctDie == "no")
                    {
                        Console.WriteLine("The die class is functioning correctly");
                    }

                    else if (correctDie == "yes")
                    {
                        Console.WriteLine("The die class in not functioning correctly");
                    }
                }

                while (ask == true)//while loop which forces users to answer yes or no and will repeat if anything else is said
                {
                    Console.WriteLine("Would you like to test again?");//gives the user the ability to test a class or results again
                    string redo = Console.ReadLine();

                    if (redo == "yes")
                    {
                        testAgain = true;
                        ask = false;
                    }

                    else if (redo == "no")
                    {
                        testAgain = false;
                        ask = false;
                    }

                    else
                    {
                        Console.WriteLine("Please enter yes or no");
                        ask = true;
                    }
                }
            }
        }
    }
}
