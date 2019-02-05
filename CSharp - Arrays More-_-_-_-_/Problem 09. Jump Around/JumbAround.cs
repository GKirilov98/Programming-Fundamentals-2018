using System;
using System.Linq;

namespace Problem_09._Jump_Around
{
    class JumbAround
    {

        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int num = nums[0];
            int index = 0;
            int step = num;
            int sum = num;

            while (true)
            {
                if (index + step < nums.Length)
                {
                    num = nums[step + index];
                    index = index + step;
                    step = num;
                    sum += num;
                }
                else if (index - step >= 0)
                {
                    num = nums[index - step];
                    index = index - step;
                    step = num;
                    sum += num;
                }
                else
                {
                    Console.WriteLine(sum);
                    return;
                }
            }
        }
    }
}


