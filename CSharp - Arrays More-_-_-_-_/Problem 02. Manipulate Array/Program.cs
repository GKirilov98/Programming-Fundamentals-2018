using System;
using System.Linq;

namespace Problem_02._Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(' ').ToArray();
            int numOperation = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOperation; i++)
            {
                string[] operation = Console.ReadLine().Split(' ');
                if (operation.Length == 3)
                {
                    int index = int.Parse(operation[1]);
                    inputArr[index] = operation[2];
                }

                if (operation[0] == "Distinct")
                {
                    DistringArr(inputArr);
                }

                if (operation[0] == "Reverse")
                {
                    Array.Reverse(inputArr);
                }
            }
            PrintInputArr(inputArr);
        }




        static void PrintInputArr(string[] inputArr)
        {
            inputArr = inputArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine(String.Join(", ", inputArr));
        }

        static void DistringArr(string[] inputArr)
        {
            for (int k = 0; k < inputArr.Length; k++)
            {
                for (int j = k + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[k] == inputArr[j])
                    {
                        inputArr[j] = null;
                    }
                }
            }
        }
    }
}

