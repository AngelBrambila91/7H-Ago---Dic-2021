using System;
using static System.Console;
namespace NullHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null; // complie error
            int? thisCouldBeNull = null;
            WriteLine($"This is a null {thisCouldBeNull}");
            WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            WriteLine(thisCouldBeNull);
            WriteLine(thisCouldBeNull.GetValueOrDefault());
        }
    }
}
