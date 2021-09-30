using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int oddSum = 0;
            int evensum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    evensum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            int diffference = evensum - oddSum;
            Console.WriteLine(diffference);
        }
    }
}
