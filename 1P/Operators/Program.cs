using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unary Operators
            int a = 3;
            int b = a++;

            // Binary Operators
            // +
            // -
            // *
            // /
            // %

            // Assignment Operators
            a = 6;
            a+=3;
            a-=3;
            a*=3;
            a/=3;

            // Logical Operators
            bool c = true;
            bool d = false;
            WriteLine($"AND |c      |d");
            WriteLine($"c   | {c & c, -5} | {c & d, -5}");
            WriteLine($"d   | {d & c, -5} | {d & d, -5}");
            WriteLine();
            WriteLine($"OR |c      |d");
            WriteLine($"c   | {c | c, -5} | {c | d, -5}");
            WriteLine($"d   | {d | c, -5} | {d | d, -5}");
            WriteLine();
            WriteLine($"XOR |c      |d");
            WriteLine($"c   | {c ^ c, -5} | {c ^ d, -5}");
            WriteLine($"d   | {d ^ c, -5} | {d ^ d, -5}");
            WriteLine();

            // Conditional Operators
            WriteLine($"c && DoStuff() = {c && DoStuff()}");
            WriteLine($"d && DoStuff() = {d && DoStuff()}");

            // Binary BitWise Operator
            int e = 10; // 0000 1010
            int f = 6; //  0000 0110
            WriteLine($"e = {e}");
            WriteLine($"f = {f}");
            WriteLine($"e & f = {e & f}");
            WriteLine($"e | f = {e | f}");
            WriteLine($"e ^ f = {e ^ f}");

            // Left Shift 3 columns
            WriteLine($"e << 3 = {e << 3}");
            WriteLine($"e * 8 = {e * 8}");
            WriteLine($"f >> 1 = {f >> 2}");

            // Miscelaneous operators
            // nameof
            // sizeof
            int age = 30;
            char firstDigit = age.ToString()[0];
            // 4 Operators
            // = Assignation operator
            // . Member acces operator
            // () Invocation operator
            // [] Indexer Acces Operator
        }
        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff");
            return true;
        }
    }
}
