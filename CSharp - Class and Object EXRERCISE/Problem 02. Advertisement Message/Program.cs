using System;

namespace Problem_02._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrase = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int phraseIndex = rnd.Next(0, phrase.Length);
                int eventIndex = rnd.Next(0, events.Length);
                int authorIndex = rnd.Next(0, author.Length);
                int townIndex = rnd.Next(0, city.Length);


            Console.WriteLine($"{phrase[phraseIndex]} {events[eventIndex]} {author[authorIndex]} – {city[townIndex]}");
            }
        }
    }
}
