using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_05._Short_Words_Sorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]{'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            List<string> text = Console
                .ReadLine()
                .ToLower()
                .Split(separators)
                .ToList();

            var words = text
                .Where(word => word.Length < 5)
                .Where(word => word !="")
                .OrderBy(x => x)
                .Distinct();
            
            Console.WriteLine(String.Join(", ", words));
        }
    }
}
