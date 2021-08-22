using System;
using static System.Console;
using System.IO;

namespace Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If
                /* 
                if (expression1)
                {
                    runs if expression1 is true
                }
                else if(expression2)
                {
                    runs if expression1 is false and expression2 is true    
                }
                ....
                else
                {
                    runs if all expressions are false
                }
                 */
            #endregion

            #region Pattern matching IF
                object o = 3;
                int j = 4;
                if(o is int i)
                {
                    WriteLine($"{i} x {j} = {i * j}");
                }
                else
                {
                    WriteLine("o is not an int so it cannot multiply");
                }
            #endregion

            #region Switch
                A_label:
                var number = (new Random()).Next(1, 7);
                WriteLine($"My Random number is {number}");
                switch (number)
                {
                    case 1:
                    WriteLine("One");
                    break;

                    case 2:
                    WriteLine("Two");
                    goto case 1;
                    
                    case 3:
                    case 4:
                    WriteLine("Three or four");
                    goto case 1;

                    case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;

                    default:
                    WriteLine("Default");
                    break;
                }
            #endregion

            #region Pattern MAtch Switch
                string path = @"D:\Code\Test";
                Write("Press R for readonly or W for write: ");
                ConsoleKeyInfo key = ReadKey();
                WriteLine();
                Stream s = null;
                if(key.Key == ConsoleKey.R)
                {
                    s = File.Open
                    (
                        Path.Combine(path, "file.txt"),
                        FileMode.OpenOrCreate,
                        FileAccess.Read
                    );
                }
                else
                {
                    s = File.Open
                    (
                        Path.Combine(path, "file.txt"),
                        FileMode.OpenOrCreate,
                        FileAccess.Write
                    ); 
                }

                string message = string.Empty;
                switch(s)
                {
                    case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that i can write to.";
                    break;

                    case FileStream readoOnlyFile:
                    message = "The stream is a read-only file.";
                    break;

                    case MemoryStream ms:
                    message = "The stream is a memory Address.";
                    break;

                    default:
                    message = "The stream is some other type";
                    break;

                    case null:
                    message = "The stream is null";
                    break;
                }

                #region Simplified Switch
                    message = s switch
                    {
                        FileStream writeableFile when s.CanWrite
                    => "The stream is a file that i can write to.",

                        FileStream readoOnlyFile
                    => "The stream is a read-only file.",

                    MemoryStream ms
                    => "The stream is a memory Address.",

                    
                    null
                    => "The stream is null",
                    _ 
                    => "The stream is some other type"
                    };
                #endregion

                WriteLine(message);
            #endregion

        }
    }
}
