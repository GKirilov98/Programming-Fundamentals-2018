using System;
using System.Linq;

namespace _05._Rounding_Numbers_Away_from_Zero
{
    class RNAfromZero
    {
        static void Main(string[] args)
        {
            double[] nums = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            double[] arrAweyFromZero = new double[nums.Length];

            GetAweyFromZero(nums, arrAweyFromZero);
            PrintAweyFromZero(nums, arrAweyFromZero);

        }

       static void PrintAweyFromZero(double[] nums, double[] arrAweyFromZero)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {arrAweyFromZero[i]}");
            }
        }

       static void GetAweyFromZero(double[] nums, double[] arrAweyFromZero)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                arrAweyFromZero[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }
        }
    }
}
