using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial version below:
            //Console.WriteLine("Please enter a comma-separated list of numbers!");
            //var userNumberList = Console.ReadLine();
            //Console.WriteLine("Please enter 1 if you would like to multiply them or 2 if you would like to square them.");
            //var userOption = Console.Read();
            //Version with shorthand below:

            Console.WriteLine(@"Please specify the operation you would like to complete, followed by a space(! Don't forget the space!):
                * for multiplication,
                ^2 if you would like to square the numbers,
                + to add them up,
                / to divide them,
        And then specify a comma-separated list of numbers.");
            
            //Logic below: Grab the whole input from the user and then separate it into the math operation requested ("* " or "^2") and the string of numbers:
            var input = Console.ReadLine();
            var userNumberList = input.Substring(2);
            var userOption = input.Substring(0, 2);
            //Console.WriteLine($"full input is: {input}");
            //Console.WriteLine($"substring is: {userNumberList}");
            //Console.WriteLine($"selected option is: {userOption}");

            int[] squareNumList = Array.ConvertAll(userNumberList.Split(','), int.Parse);
            //note about the line above: When working on Part2 of this exercise, it seemed that the easiest thing to do was create a copy of the initial array entered by the user and then replace the individual items in the array with their squared value. Since I didn't know what the exact length of the array might be!!! (the user could enter any number of numbers).
            //Console.WriteLine($"Initial squareNumList: { squareNumList }");

            if (userOption == "* ")
            {
                var intArray = Array.ConvertAll(userNumberList.Split(','), int.Parse);
                //Console.WriteLine($"intArray: {intArray}");
                int multipliedTotal = 1;
                for (int i = 0; i < intArray.Length; i++)
                {
                    multipliedTotal = intArray[i] * multipliedTotal;
                    //Console.WriteLine($"i: { intArray[i]}");
                }
                Console.WriteLine($"And the total result of multiplying these values together is: {multipliedTotal}.");

            } else if (userOption == "^2")
            {
                var intArray = Array.ConvertAll(userNumberList.Split(','), int.Parse);
                //Console.WriteLine($"intArray: {intArray}");
                for (int i = 0; i < intArray.Length; i++)
                {
                    //Console.WriteLine($"i: { intArray[i]}");
                    var squareNum = intArray[i] * intArray[i];
                    squareNumList[i] = squareNum;
                    //string.Join(',', squareNumList[i]);
                    //Console.WriteLine($"Individual square number: { squareNum }");
                }
                Console.WriteLine("Final list of your numbers squared:" + string.Join(',', squareNumList));
                //NOTE about the string.Join method above: to prevent the output of this array being System.Int32[] - which it was!! because apparently when you print an array of integers, the ToString() method is applied and the type of the array gets printed -- you have to do the following:
                //Instead of the type of the array, I want to print the value and the string.Join method helps me concatenate all those integers (using the specified separator) so that I can print them!
            } else if (userOption == "+ ")
            {
                var intArray = Array.ConvertAll(userNumberList.Split(','), int.Parse);
                int sum = 0;
                for (int i = 0; i < intArray.Length; i++)
                {
                    sum = intArray[i] + sum;
                }
                Console.WriteLine($"And the total sum of these values is: {sum}.");

            } else if (userOption == "/ ")
            {
                var intArray = Array.ConvertAll(userNumberList.Split(','), int.Parse);
                int result = 0;
                //Find the index of the last item in the array - and as long as the item we are on during the loop isn't that last one, then do the division; otherwise, just return the result:
                int lastItemIndex = intArray.GetUpperBound(0);
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (i != lastItemIndex)
                    {   
                        result = intArray[i] / intArray[i + 1];
                        Console.WriteLine($"result at this point is: {result}!");
                    }
                }
                Console.WriteLine($"And the result after dividing the first value by the subsequent one is: {result}");


            }

        }
    }
}
