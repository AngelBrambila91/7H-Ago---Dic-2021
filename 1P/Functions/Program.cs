using System;
using static System.Console;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunTimesTable();
            //RunCalculateTax();
            RunFibImperative();
            
        }
        /// <summary>
        /// Function that takes number and print table in console
        /// </summary>
        /// <param name="number">Byte type, so ... only between 0 and 255</param>
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} * {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255 : ");
                isNumber = byte.TryParse(
                    ReadLine(), out byte number
                );
                if(isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!, Please Try again");
                }
            } while (!isNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="twoLetterRegionCode"></param>
        /// <returns></returns>    
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH":
                rate = .16M;
                break;

                case "MX":
                case "JL":
                rate = .18M;
                break;

                case "SO":
                rate = .09M;
                break;

                default:
                rate = .12M;
                break;
            }
            return amount * rate;
        }

        static void RunCalculateTax ()
        {
            Write ("Enter amount : ");
            string amountInText = ReadLine();
            Write ("Enter a two-letter region code: ");
            string region = ReadLine();
            if(decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax");
            }
            else
            {
                WriteLine("you did not enter a valid amount ... plz bro");
            }
        }
    
    
        static int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            if (term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term-1) + FibImperative(term -2);
            }

        }
             static void RunFibImperative()
             {
                 for (int i = 1; i <= 30; i++)
                 {
                     WriteLine($"The {i} term of the Fiboniacci sequence is {FibImperative(term: i)}");
                 }
             }

             static int FibFunctional(int term) =>
             term switch
             {
                 1 => 0,
                 2 => 1,
                 _ => FibFunctional(term -1) + FibFunctional(term -2)
             };

            static void RunFibFunctional()
             {
                 for (int i = 1; i <= 30; i++)
                 {
                     WriteLine($"The {i} term of the Fiboniacci sequence is {FibImperative(term: i)}");
                 }
             }
    }
}
