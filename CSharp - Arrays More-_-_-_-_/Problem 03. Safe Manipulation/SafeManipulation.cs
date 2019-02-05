using System;
using System.Linq;
namespace Problem_03._Safe_Manipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                string[] operation = Console.ReadLine().Split(' ');
                if (operation[0] == "END")
                {
                    break;
                }

                inputArr = inputArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                ReplaceArr(inputArr, operation);
                DistinctArr(inputArr, operation);
                ReverseArr(inputArr, operation);
                InvalidComand(operation);
            }

            PrintInputArr(inputArr);
        }

        static void InvalidComand(string[] operation)
        {
            if (operation[0] != "Replace" && operation[0] != "Distinct" && operation[0] != "Reverse" && operation[0] != "END")
            {
                Console.WriteLine("Invalid input!");
            }
        }

        static void ReplaceArr(string[] inputArr, string[] operation)
        {
            if (operation.Length == 3 && operation[0] == "Replace")
            {
               
                    int index = int.Parse(operation[1]);
                if (index < 0 || index > inputArr.Length - 1)
                {
                    Console.WriteLine("Invalid input!");
                }else
                {
                    inputArr[index] = operation[2];
                }
            }
        }

        static void ReverseArr(string[] inputArr, string[] operation)
        {
            if (operation[0] == "Reverse")
            {
                Array.Reverse(inputArr);
            }
        }

        static void DistinctArr(string[] inputArr, string[] operation)
        {
            if (operation[0] == "Distinct")
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

        static void PrintInputArr(string[] inputArr)
        {
            Console.WriteLine(String.Join(", ", inputArr));
        }

    }
}

