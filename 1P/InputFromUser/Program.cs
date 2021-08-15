using System;
using static System.Console;
namespace InputFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Gettinf info from user
            // Console.Write("Type your first name and Press Enter : ");
            // string firstName = Console.ReadLine();
            // Console.Write("Type your age and press ENTER : ");
            // string age = Console.ReadLine();
            // Console.WriteLine($"Hello THERE!! GENERAL {firstName}, you look good for {age}");
            // Console.ReadLine(); // system("pause");    
            #endregion
            
            #region Getting KEY From User
                Write ("Press ANY Combination : ");
                ConsoleKeyInfo key = ReadKey();
                WriteLine();
                WriteLine($"Key : {key.Key}, Char: {key.KeyChar}, Modifiers {key.Modifiers}");
            #endregion

            #region Using Args
                WriteLine($"There are {args.Length} arguments");
                if(args.Length < 3)
                {
                    WriteLine("You must specify wto colors at least and size ... example ...");
                    WriteLine("dotnet run red yellow 50");
                    return;
                }
                ForegroundColor = (ConsoleColor) Enum.Parse( 
                    enumType: typeof(ConsoleColor),
                    value: args[0],
                    ignoreCase:true
                    );

                BackgroundColor = (ConsoleColor) Enum.Parse( 
                    enumType: typeof(ConsoleColor),
                    value: args[1],
                    ignoreCase:true
                    );
                CursorSize = int.Parse(args[2]);
            #endregion
        }
    }
}
