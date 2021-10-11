using System;
using System.Collections.Generic;
using static System.Console;

namespace Shared
{
    public class Person
    {
        // Fields = store data, private fields ... encapsulation
        // Constant =
        // Read - only
        // Event
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth {get; set;}


        public HashSet<Person> Children {get; set;}

        protected decimal Salary { get; set; }


        // Methods
        // Contructor
        // Property
        // Indexer
        // Operator


        public Person()
        {


        }

        public Person (decimal initSalary)
        {
            Salary = initSalary;
        }




        public (string Name, int Number) GetFruit()
        {
            return (Name : "Apples" ,Number : 5);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // our params CANNOT HAVE DEFAULT!!!!!
            z = 100;
            x ++;
            y ++;
            z ++;
        }

        public int MethodIWantToCall(string input)
        {
            return input.Length;
        }

        // event Delegate field
        public EventHandler Shout;
        // data field
        public int AngerLevel;
        public void Poke ()
        {
            AngerLevel ++;
            if(AngerLevel >= 3)
            {
                if(Shout != null)
                {
                    Shout(this, EventArgs.Empty);
                }
            }
        }
    }
}
