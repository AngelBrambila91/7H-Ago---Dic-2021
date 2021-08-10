using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Basic Numbers
            uint naturalNumber = 23;
            int integerNumber = -24;
            float realNumber = 2.3F;
            double anotherRealNumber = 2.3;
                
            #endregion

            #region Notations
                // variable for 2 million
                int decimalNotation = 2_000_000;
                int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
                int hexadecimalNotation = 0x_001E_8480;
                Console.WriteLine($"decimal == binary ???? {decimalNotation == binaryNotation}");
                Console.WriteLine($"decimal == hex ???? {decimalNotation == hexadecimalNotation}");
            #endregion

            #region Why decimal is better
                Console.WriteLine("Using double :");
                double a = 0.1;
                double b = 0.2;
                if (a + b == 0.3)
                {
                    Console.WriteLine($"{a} + {b}  equals 0.3");
                }
                else
                {
                    Console.WriteLine($"{a} + {b}  = {a + b}");
                }

                Console.WriteLine("Using decimal :");
                decimal c = 0.1M;
                decimal d = 0.2M;
                if (c + d == 0.3M)
                {
                    Console.WriteLine($"{c} + {d}  = {c + d}");
                }
                else
                {
                    Console.WriteLine($"{c} + {d}  = {c + d}");
                }
            #endregion
        }
    }
}
