using System;
using System.IO;
using System.Xml;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region object    
            object height = 1.88;
            object name = "Zurdo";
            Console.WriteLine($"{name} is {height} meters tall.");
            string name2 = "NAdia";
            //int lenght1 = name.Length; // error
            int lenght2 = ((string)name).Length;
            Console.WriteLine($"{name} is {lenght2} meters tall.");
            #endregion

            #region dynamic
                //storing a dynamic object
                dynamic anotherName = "ElRo";
                int length = anotherName.Length;
                Console.WriteLine($"{anotherName} is {length}");
            #endregion

            #region var
                var population = 66_000_000;
                var weight = 1.90;
                var price = 500.4M;
                var fruit = "Strawberry";
                var letter = 'Z';
                var happy = true;

                // create an XML file
                var xml1 = new XmlDocument();
            #endregion

        }
    }
}
