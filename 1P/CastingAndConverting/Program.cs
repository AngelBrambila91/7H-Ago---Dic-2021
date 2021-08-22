using System;
using static System.Console;
using static System.Convert;
namespace CastingAndConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            // Implicit Casting , Explicit Casting
            int a = 10;
            double b = a; // Implicit Casting,
            WriteLine(b);
            double c = 9.8;
            int d = (int)c;
            WriteLine(d);

            long e = 5_000_000_000;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            #endregion

            #region Convert
                double g = 9.8;
                int h = ToInt32(g);
                WriteLine($"g is {g} and h is {h}");

                double[] doub = new [] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
                foreach (double n in doub)
                {
                    WriteLine($"ToInt({n}) is {ToInt32(n)}");
                }

                foreach (double n in doub)
                {
                    WriteLine(format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                        arg0: n,
                        arg1: Math.Round(value: n, digits: 0, mode:MidpointRounding.AwayFromZero)
                    );
                }
            #endregion

            #region Converting TO String
                int number = 12;
                WriteLine(number.ToString());
                bool boolean = true;
                WriteLine(boolean.ToString());
                object me = new object();
                WriteLine(me.ToString());
            #endregion

            #region Binary to String
                // 128 bytes
                byte[] binaryObject = new byte[128];
                (new Random()).NextBytes(binaryObject);
                WriteLine("Binary Object as bytes: ");
                for (int i = 0; i < binaryObject.Length; i++)
                {
                    Write($"{binaryObject[i]:X} ");
                }
                string encoded = ToBase64String(binaryObject);
                WriteLine();
                WriteLine($"Binary Object as Base64 : {encoded}");
            #endregion

            #region Parse
                int age = int.Parse("30");
                DateTime birthday = DateTime.Parse("2 August 1991");
                WriteLine($"I was bors {age} years ago");
                WriteLine($"My Birthday is {birthday}");
                WriteLine($"My Birthday is {birthday:D}");
            #endregion

            #region Try Parse
                Write("How many Zurdos are there? ");
                int count;
                string input = ReadLine();
                if(int.TryParse(input, out count))
                {
                    WriteLine($"There are {count} Zurdos");
                }
                else
                {
                    WriteLine("I Could not parse the input");
                }
            #endregion
        }
    }
}
