using System;

namespace Problem_9._Count_the_Integers
{
    class countIntegers
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);


            }
        }
    }
}

