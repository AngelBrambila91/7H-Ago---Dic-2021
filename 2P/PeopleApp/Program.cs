using System;
using Shared;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace PeopleApp
{
    class Program
    {
        delegate int DelegateWithMatchingSignature(string s);
        static void Main(string[] args)
        {
            // #region Simple Instantiate
            // var zurdo = new Person();
            // zurdo.Name = "Zurdito UwU";
            // zurdo.DateOfBirth = new DateTime(1960, 12, 22);
            // zurdo.BestFood = BestFood.Tacos;
            // WriteLine($"{zurdo.Name} was born on {zurdo.DateOfBirth: d MMMM yyyy}... Integer food is {zurdo.BestFood}");
            // WriteLine($"{zurdo.Name} has {zurdo.Children.Count} chrildren");



            // var camila = new Person
            // {
            //     Name = "Camila Zamora",
            //     DateOfBirth = new DateTime(1998, 3, 7)
            // };
            // WriteLine($"{camila.Name} was born on {camila.DateOfBirth: d MMMM yyyy}");
            // #endregion

            // #region Using Bank
            //      BankAccount.InterestRate = 0.016M;
            //      var asafAccount = new BankAccount();
            //      asafAccount.AccountName = "Mr. Asaf";
            //      asafAccount.Balance = 2400;
            //      WriteLine($"{asafAccount.AccountName} earned {asafAccount.Balance *  BankAccount.InterestRate} interest");
            // #endregion

            // #region Value by DEfault
            //      var blankPerson = new Person();
            //      WriteLine($"{blankPerson.Name} was created at {blankPerson.HomePlanet} on a {blankPerson.Instantiated: hh:mm:ss}");
            //      var blankPerson2 = new Person();
            //      WriteLine($"{blankPerson2.Name} was created at {blankPerson2.HomePlanet} on a {blankPerson2.Instantiated: hh:mm:ss}");
            // #endregion

            // #region Using Another Contructor
            //      var adrian = new Person("Adrian", "Mars");
            //      WriteLine($"{adrian.Name} was created at {adrian.HomePlanet} on a {adrian.Instantiated: hh:mm:ss}");
            // #endregion

            // #region Using Methods
            //      camila.WriteToConsole();
            //      WriteLine(camila.GetOrigin());
            // #endregion

            // #region Using Tuples
            //      var fruit = camila.GetFruit();
            //      WriteLine($"{fruit.Number}, {fruit.Name} there are");
            // #endregion

            // #region Passing Parameters
            // int a = 10;
            // int b = 20;
            // int c = 30;
            // WriteLine($"Before : a = {a} , b = {b}, c = {c}");
            // zurdo.PassingParameters(a, ref b, out c);
            // WriteLine($"After : a = {a} , b = {b}, c = {c}");
            
            // #endregion
     
            // #region Creating Flight Passengers
            //      object[] passengers =  {
            //          new FirstClassPaseenger { AirMiles = 1_419 },
            //          new FirstClassPaseenger { AirMiles = 16_526 },
            //          new BusinessClassPasenger(),
            //          new CoachClassPassenger { CarryOnKG = 25.7 },
            //          new CoachClassPassenger { CarryOnKG = 0 },
            //          new FirstClassPaseenger { AirMiles = 1_700 },
            //      };

            //      foreach (object passenger in passengers)
            //      {
            //          decimal flightCost = passenger switch
            //          {
            //              FirstClassPaseenger p when p.AirMiles > 35000 => 1500M,
            //              FirstClassPaseenger p when p.AirMiles > 15000 => 1750M,
            //              FirstClassPaseenger _                         => 2000M,
            //              BusinessClassPasenger _                       => 1000M,// facade
            //              CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
            //              CoachClassPassenger _                         => 650,
            //              _                                             => 800M
            //          };
            //          WriteLine($"Flight costs {flightCost:C} for {passenger}");
            //      }
            // #endregion

            // camila.MethodIWantToCall("Hola");
            
            // var d = new DelegateWithMatchingSignature(camila.MethodIWantToCall);
            // int answer = d("Frog");

            // zurdo.Shout += Zurdo_Shout;
            // zurdo.Poke();
            // zurdo.Poke();
            // zurdo.Poke();
            // zurdo.Poke();
            // zurdo.Poke();
            // zurdo.Poke();
            // camila.Shout += Zurdo_Shout;
            // camila.Poke();

            #region Serialize
                 var people = new List<Person>
                 {
                     new Person(30000M) 
                     {
                        FirstName = "Ro",
                        LastName = "El billulo",
                        DateOfBirth = new DateTime(1970, 3, 14)
                     },
                    new Person(20000M) 
                     {
                        FirstName = "Danny",
                        LastName = "Lozano",
                        DateOfBirth = new DateTime(1980, 4, 14),
                        Children = new HashSet<Person>
                        {
                            new Person(0M)
                            {
                                FirstName = "Danielito",
                                LastName = "LozanitoUwU",
                                DateOfBirth = new DateTime(2001, 12, 25)
                            }
                        }
                     }
                 };

                 var xs = new XmlSerializer(typeof(List<Person>));
                 string path = Combine(CurrentDirectory,"people.xml");
                 using (FileStream stream = File.Create(path))
                 {
                     xs.Serialize(stream, people);
                 }

            #endregion
        }

    }
}
