using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6._Sum_big_numbers
{
    class SumBigNum
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine().TrimStart(new char[] { '0' });
            string secondNum = Console.ReadLine().TrimStart(new char[] { '0' });

            if (firstNum.Length >= secondNum.Length)
            {
                SumNumbers(firstNum, secondNum);
            }
            else
            {
                SumNumbers(secondNum, firstNum);
            }

        }

        static void SumNumbers(string bigger, string smaller)
        {
            StringBuilder sum = new StringBuilder();
            int reminder = 0;
            StringBuilder smaller1 = new StringBuilder();
            int addedNull = bigger.Length - smaller.Length;
            smaller1.Append('0', addedNull);
            smaller1.Append(smaller);
            for (int i = bigger.Length -1; i >= 0; i--)
            {
                int firstNum = int.Parse(bigger[i].ToString());
                int secondNum = int.Parse(smaller1[i].ToString());

                int result = firstNum + secondNum + reminder;

                if (result > 9)
                {
                    if (i != 0)
                    {
                        result -= 10;
                        reminder = 1;
                    }
                }
                else
                {
                    reminder = 0;
                }
                sum.Append(new string (result.ToString().Reverse().ToArray()));
            }
          
            string reversed = new String (sum.ToString().Reverse().ToArray());
            Console.WriteLine(reversed); 

        }
    }
}
