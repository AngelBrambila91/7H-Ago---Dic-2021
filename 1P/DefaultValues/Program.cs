using System;
using static System.Console;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default Values
                WriteLine($"default(int) = {default(int)}");
                WriteLine($"default(bool) = {default(bool)}");
                WriteLine($"default(DateTime) = {default(DateTime)}");
                WriteLine($"default(string) = {default(string)}");
            #endregion

            #region Arrays
                // list of names
                string [] names;
                names = new string[4];
                // storing names
                names[0] = "Zurdo";
                names[1] = "Lozano";
                names[2] = "Ro";
                names[3] = "Camila";

                // looping
                for (int i = 0; i < names.Length; i++)
                {
                    WriteLine(names[i]);
                }
            #endregion

        }
    }
}
