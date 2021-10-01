using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(" ");
            string[] arrTwo = Console.ReadLine().Split(" ");

            foreach(string elementsTwo in arrTwo)
            {
                for(int i = 0; i <arrOne.Length; i++)
                {
                    string elementOne = arrOne[i];
                    if(elementsTwo == elementOne)
                    {
                        Console.Write(elementOne + (" "));
                        break;
                    }
                }
            }
        }
    }
}
