using System;

namespace Problem_12._Number_checker
{
    class NumChecker
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
              
            }
        }
    }
}
