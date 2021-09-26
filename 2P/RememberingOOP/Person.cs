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
        public string Name;
        public DateTime DateOfBirth;
        public BestFood BestFood;

        public List<Person> Children = new List<Person>();
        public const string Sepecies = "Homo Sapien";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;


        // Methods
        // Contructor
        // Property
        // Indexer
        // Operator
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
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

    }
}
