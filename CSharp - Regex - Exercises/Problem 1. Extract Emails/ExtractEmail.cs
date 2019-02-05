using System;
using System.Text.RegularExpressions;

namespace Problem_1._Extract_Emails
{
    class ExtractEmail
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\s[A-Z0-9a-z]+(([.]|[\-]|[_])[A-Z0-9a-z]+)*@[A-Za-z0-9]+(([-])[A-Za-z0-9]*)?.[A-Z0-9a-z]+([.][a-z]+)";
            Regex regex = new Regex(pattern);
            var validEmails = regex.Matches(input);
            Console.WriteLine(String.Join(System.Environment.NewLine, validEmails));
        }
    }
}
