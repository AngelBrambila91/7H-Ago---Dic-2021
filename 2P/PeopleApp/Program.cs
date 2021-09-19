using System;
using Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple Instantiate
            var zurdo = new Person();
            zurdo.Name = "Zurdito UwU";
            zurdo.DateOfBirth = new DateTime(1960, 12, 22);
            zurdo.BestFood = BestFood.Tacos;
            WriteLine($"{zurdo.Name} was born on {zurdo.DateOfBirth: d MMMM yyyy}... Integer food is {zurdo.BestFood}");
            zurdo.Children.Add(new Person {Name = "Zurdito"});
            zurdo.Children.Add(new Person {Name = "Derecha"});
            WriteLine($"{zurdo.Name} has {zurdo.Children.Count} chrildren");
            for (int child = 0; child < zurdo.Children.Count; child++)
            {
                WriteLine($"{zurdo.Children[child].Name}");
            }


            var camila = new Person
            {
                Name = "Camila Zamora",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            WriteLine($"{camila.Name} was born on {camila.DateOfBirth: d MMMM yyyy}");
            #endregion

            #region Using Bank
                 BankAccount.InterestRate = 0.016M;
                 var asafAccount = new BankAccount();
                 asafAccount.AccountName = "Mr. Asaf";
                 asafAccount.Balance = 2400;
                 WriteLine($"{asafAccount.AccountName} earned {asafAccount.Balance *  BankAccount.InterestRate} interest");
            #endregion

            #region Value by DEfault
                 var blankPerson = new Person();
                 WriteLine($"{blankPerson.Name} was created at {blankPerson.HomePlanet} on a {blankPerson.Instantiated: hh:mm:ss}");
                 var blankPerson2 = new Person();
                 WriteLine($"{blankPerson2.Name} was created at {blankPerson2.HomePlanet} on a {blankPerson2.Instantiated: hh:mm:ss}");
            #endregion

            #region Using Another Contructor
                 var adrian = new Person("Adrian", "Mars");
                 WriteLine($"{adrian.Name} was created at {adrian.HomePlanet} on a {adrian.Instantiated: hh:mm:ss}");
            #endregion



        }
    }
}
