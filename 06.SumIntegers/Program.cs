using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            //You are given a sequence of positive integer values written into a string, separated by spaces.
            //Write a function that reads these values from given string and calculates their sum.

            Console.WriteLine("Enter numbers separated by space: ");
            string numbers = Console.ReadLine();
            string[] numbersString = numbers.Split(' ');
            int[] myArray = new int[numbers.Length];

            for (int i = 0; i < numbersString.Length; i++)
            {
                myArray[i] = int.Parse(numbersString[i]);
            }

            Console.WriteLine("Sum = {0}", myArray.Sum());
        }
    }
}
