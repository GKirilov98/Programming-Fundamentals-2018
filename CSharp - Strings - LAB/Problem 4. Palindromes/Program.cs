using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var builder = new StringBuilder(100);
             builder.Append("Hello Maria, how are you?");
             Console.WriteLine(builder); // Hello Maria, how are you?
             builder[6] = 'D';
             Console.WriteLine(builder); // Hello Daria, how are you?
             builder.Remove(5, 6);
             Console.WriteLine(builder); // Hello, how are you?
             builder.Insert(5, " Peter");
             Console.WriteLine(builder); // Hello Peter, how are you?
             builder.Replace("Peter", "George");
             Console.WriteLine(builder); // Hello George, how are you?
             */

            string[] words = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> palindroms = new List<string>();
            foreach (string word in words)
            {
                string reversed = new string(word.Reverse().ToArray());
                if (word == reversed)
                {
                    palindroms.Add(word);
                }
            }

            IOrderedEnumerable<string> sorted =  palindroms.Distinct().OrderBy(x => x);
            Console.WriteLine(String.Join(", ", sorted));
        }
    }
}
