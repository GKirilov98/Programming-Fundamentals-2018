using System;

namespace _8._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long IDnum = long.Parse(Console.ReadLine());
            int employee = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {sex}\nPersonal ID: {IDnum}\nUnique Employee number: {employee}");

        }
    }
}
