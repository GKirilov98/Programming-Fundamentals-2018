using System;

namespace Problem_1._Hello_Name
{
    class HelloName
    
    {
        static void Main(string[] args)
        {
            PrintHelloName();
        }
        static void PrintHelloName()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
