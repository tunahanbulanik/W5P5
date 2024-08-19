using System;

namespace W5P5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz ve karesini alacağız");
                string userInput = Console.ReadLine();

                int makeNum = int.Parse(userInput);

                double squareNum = Math.Pow(makeNum, 2);  // Square a number

                Console.WriteLine($"Girdiğiniz sayının karesi {squareNum}");
            }
            catch (FormatException) 
            {
                Console.WriteLine("WRONG INPUT AGACIM");
            }
        }
    }
}