using System;

namespace Problem_1._Padawan_Equipment
{
    class PadawanEquip
    {
        static void Main(string[] args)
        {
            Decimal budged = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            Decimal lightsabersPrice = decimal.Parse(Console.ReadLine());
            Decimal robesPrice = decimal.Parse(Console.ReadLine());
            Decimal beltsPrice = decimal.Parse(Console.ReadLine());

            int lightsabersCount = (int) Math.Ceiling(studentsCount * 1.10);
            int robesCount = studentsCount;
            int beltCount = 0;
            for (int i = 1; i <= studentsCount; i++)
            {
                beltCount++;
                if (i % 6 == 0)
                {
                    beltCount--;
                }
            }

            Decimal neededMoney = (lightsabersPrice * lightsabersCount) +
                (robesPrice * robesCount) +
                (beltsPrice * beltCount);

            if ((budged - neededMoney) >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(budged - neededMoney):f2}lv more.");
            }
        }
    }
}
