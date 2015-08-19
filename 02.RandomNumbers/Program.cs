using System;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that generates and prints to the console 10 random values in the range [100, 200]

            Random randomNumber = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Random number {0} = {1}", i + 1, randomNumber.Next(100, 201));
            }
            
        }
    }
}
