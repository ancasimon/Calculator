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
            Console.WriteLine("Please enter 1 if you would like to multiply them or 2 if you would like to square them.");
            var userOption = Console.Read();
            int[] squareNumList = Array.ConvertAll(userNumberList.Split(','), int.Parse);
            //Console.WriteLine($"Initial squareNumList: { squareNumList }");
            if (userOption == '1')
            {
                var intArray = Array.ConvertAll(userNumberList.Split(','), int.Parse);
                //Console.WriteLine($"intArray: {intArray}");
                int multipliedTotal = 1;
                for (int i = 0; i < intArray.Length; i++)
                {
                    multipliedTotal = intArray[i] * multipliedTotal;
                    //Console.WriteLine($"i: { intArray[i]}");
                }
                Console.WriteLine($"And the total result of multiplying these values together is: {multipliedTotal}");
            } else if (userOption == '2')
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

            }
            
        }
    }
}
