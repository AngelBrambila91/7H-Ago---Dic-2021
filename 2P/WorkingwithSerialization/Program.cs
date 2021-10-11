using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Environment;
using static System.IO.Path;
using static System.Console;

namespace WorkingwithSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
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

                #region Serialize JSON
                     string jsonPath = Combine(CurrentDirectory, "people.json");
                     using (StreamWriter jsonStream = File.CreateText(jsonPath))
                     {
                         var jss = new Newtonsoft.Json.JsonSerializer();
                         jss.Serialize(jsonStream, people);
                     }

                     WriteLine();
                     WriteLine($"Written {new FileInfo(jsonPath).Length:N0} bytes of JSON to : {jsonPath}");
                     WriteLine(File.ReadAllText(jsonPath));
                #endregion
        }
    }
}
