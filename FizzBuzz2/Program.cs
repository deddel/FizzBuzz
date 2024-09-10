using System;

//Reads a single test case. Each test case contains three integers
//on a single line, X Y and N (1≤X<Y≤N≤100).

//Outputs integers from 1 to N in order, each on its own line, replacing the
//ones divisible by X with Fizz, the ones divisible by Y with Buzz and ones
//divisible by both X and Y with FizzBuzz..

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read the input numbers as a string and seperate the numbers in a
            //list.
            string[] numbers = Console.ReadLine().Split(' ');

            //Assign the string elements in the list to int variables.
            int X = int.Parse(numbers[0]);
            int Y = int.Parse(numbers[1]);
            int N = int.Parse(numbers[2]);

            //Loop the numbers from 1 to N. 
            for (int i = 1; i <= N ; i++)
            {
                //Creat bool variables to see if i is dividable by X and Y
                bool divByX = (i % X == 0);
                bool divByY = (i % Y == 0);

                //Check the conditions for each number i and write output as stated in the
                //description above.
                if (divByX && divByY)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (divByX)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divByY)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}