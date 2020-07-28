using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a comma-separated list of numbers!");
            var userNumberList = Console.ReadLine();
            var intArray = Array.ConvertAll(userNumberList.Split(','), int.Parse);
            //Console.WriteLine($"intArray: {intArray}");
            int multipliedTotal = 1;
            for (int i = 0; i < intArray.Length; i++)
                { 
                  multipliedTotal = intArray[i] * multipliedTotal;
                //Console.WriteLine($"i: { intArray[i]}");
                }
            Console.WriteLine($"And the total result of multiplying these values together is: {multipliedTotal}");
        }
    }
}
