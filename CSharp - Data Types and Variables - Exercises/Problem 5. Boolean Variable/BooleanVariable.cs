using System;

namespace Problem_5._Boolean_Variable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            
            if (text== "true")
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
            
           
        }
    }
}
