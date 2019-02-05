using System;
using System.Linq;

namespace Problem_05._Pizza_Ingredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int numChar = int.Parse(Console.ReadLine());

            string[] allProduct = new string[arr.Length];
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                char[] ingredient = arr[i].ToCharArray();
                if(ingredient.Length == numChar)
                {
                    allProduct[i] = arr[i];
                    Console.WriteLine($"Adding {String.Join("", ingredient)}.");
                    counter++;
                    if (counter == 10)
                    {
                        break;
                    }
                }
            }
            allProduct = allProduct.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine($"Made pizza with total of {allProduct.Length} ingredients.\r\n" +
                $"The ingredients are: {String.Join(", ",allProduct)}.");
        }
    }
}
