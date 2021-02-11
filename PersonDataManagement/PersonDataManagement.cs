using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class PersonDataManagement
    {
        public static void AddPersonDetails(List<Person> personList)
        {
            personList.Add(new Person() { SSN = 1, Name = "Dipesh", Age = 24, Address = "Mumbai" });
            personList.Add(new Person() { SSN = 2, Name = "Dhanesh", Age = 24, Address = "Banglore" });
            personList.Add(new Person() { SSN = 3, Name = "Kaousr", Age = 75, Address = "Pune" });
            personList.Add(new Person() { SSN = 4, Name = "Moenei", Age = 18, Address = "Chennai" });
            personList.Add(new Person() { SSN = 5, Name = "Itedite", Age = 24, Address = "Delhi" });
        }
        private static void ShowRecords(List<Person> PersonList)
        {
            foreach (Person Person in PersonList)
            {
                Console.WriteLine(Person.SSN);
                Console.WriteLine(Person.Name);
                Console.WriteLine(Person.Age);
                Console.WriteLine(Person.Address);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();
            AddPersonDetails(PersonList);
            ShowRecords(PersonList);
        }      
    }
}
