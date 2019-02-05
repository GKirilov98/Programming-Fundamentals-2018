using System;

namespace Problem_1___Rage_Expenses
{
    class RegaExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 2; i <= lostGames; i++)
            {
                bool displayTrash = false;
                if ( i % 2 == 0)
                {
                    headsetCount++;
                }

                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayTrash = true;
                    }
                }

                if (displayTrash)
                {
                    displayCount++;
                }
            }

            Decimal totalPrice = (headsetPrice * headsetCount) + (mousePrice * mouseCount)
                + (keyboardPrice * keyboardCount) + (displayPrice * displayCount);

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
