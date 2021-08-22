using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while
                int x = 0;
                while(x < 10)
                {
                    WriteLine(x);
                    x++;
                }
            #endregion

            #region do While
                string password = string.Empty;
                do
                {
                    Write("Enter password: ");
                    password = ReadLine();
                } while (password != "Pa$$w0rd");
                WriteLine("BINGO!");
            #endregion

            #region for
                for (int i = 0; i <= 10; i++)
                {
                    WriteLine(i);
                }
            #endregion

            #region For Each
               string[] names = {"Akali", "Zurdo", "Charlie"}; // IEnumerator, e.Next()
               foreach (string name in names)
               {
                   WriteLine($"{name} has {name.Length} characters");
               }
            #endregion
        }
    }
}
