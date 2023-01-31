using System;

/*
 * Author: Dustin Cooksey
 * Date: 01/29/2023
 * Description: This C# Console application takes a users input
 * in the form of an integer and returns either the odd or
 * even numbers between 1 and the integer depending
 * on which set the user selects.
*/

namespace Deliverable3_DustinCooksey
{
    class Deliverable3_DC
    {
        static void Main(string[] args)
        {
            try
            {
                int test = 0;
                string choice = "";

                while (true)
                {
                    Console.WriteLine("Please enter an integer between 1 and 100");
                    test = int.Parse(Console.ReadLine());

                    if (test >= 1 && test <= 100)
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Please select choose either Odd or Even");
                    choice = Console.ReadLine();
                    choice = choice.ToLower();
                    if (choice == "odd" || choice == "even");
                    {
                        break;
                    }
                }

                if (choice == "even") 
                {
                    Console.WriteLine("You have chosen the even set");
                    for (int k = 0; k < test; k=k+2)
                    {
                        Console.WriteLine(k);
                    }
                }

                if (choice == "odd") 
                {
                    Console.WriteLine("You have chosen the odd set");
                    for (int k = -1; k < test; k = k + 2)
                    {
                        Console.WriteLine(k);
                    }
                }
            }


            catch
            {
                Console.WriteLine("Please only use an integer between 1 and 100");
            }
            
        }
    }
}
