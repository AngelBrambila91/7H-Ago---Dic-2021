using System;
using static System.Console;
namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            WriteLine($"{numberOfApples} cost {pricePerApple * numberOfApples:C}");
            string formatted = string.Format(
                format: $"{numberOfApples} cost {pricePerApple * numberOfApples:C}"
            );

            string applesText = "Apples";
            int applesCount = 50*89;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            string nameText = "Name";
            string countText = "Count";
            WriteLine($"{nameText,-8} {countText,6:N0}");
            WriteLine($"{applesText,-8} {applesCount,6:N0}");
            WriteLine($"{bananasText,-8} {bananasCount,6:N0}");
        }
    }
}
