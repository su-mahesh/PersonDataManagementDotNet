using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class PersonDataManagement
    {
        public static void AddPersonDetails(List<Person> personList)
        {
            personList.Add(new Person() { SSN = 1, Name = "Dipesh", Age = 13, Address = "Mumbai" });
            personList.Add(new Person() { SSN = 2, Name = "Dhanesh", Age = 24, Address = "Banglore" });
            personList.Add(new Person() { SSN = 3, Name = "Kaousr", Age = 75, Address = "Pune" });
            personList.Add(new Person() { SSN = 4, Name = "Moenei", Age = 18, Address = "Chennai" });
            personList.Add(new Person() { SSN = 5, Name = "Itedite", Age = 59, Address = "Delhi" });
        }
        private static void ShowRecords(List<Person> PersonList)
        {
            foreach (Person Person in PersonList)
            {
                Console.WriteLine("SSN: "+ Person.SSN);
                Console.WriteLine("Name: "+ Person.Name);
                Console.WriteLine("Age: "+ Person.Age);
                Console.WriteLine("Address: "+ Person.Address);
                Console.WriteLine();
            }
        }

        static List<Person> RetrieveTop2RecordsAgeBelow60(List<Person> PersonList)
        {
            PersonList.Sort((person1, person2) => person2.Age.CompareTo(person1.Age));
            var result = PersonList.FindAll(person => person.Age < 60).Take(2).ToList();
            return result;
        }
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();
            AddPersonDetails(PersonList);
            ShowRecords(PersonList);

            List<Person>  Result = RetrieveTop2RecordsAgeBelow60(PersonList);
            Console.WriteLine("Top 2 Records Below age 60");
            ShowRecords(Result);
            Result.Clear();
            Result = RetrieveAllRecordsAgeBetween13And18(PersonList);
            ShowRecords(Result);

            double AverageAge = RetrieveAverageAge(PersonList);
            Console.WriteLine("Average ag: "+ AverageAge);

            string SearchName = "Dipesh";
            bool CheckNameResult = CheckIfNameExist(PersonList, SearchName);
            if(CheckNameResult)
                Console.WriteLine(SearchName +" exists");
            else
                Console.WriteLine(SearchName + " doesn't exist");
        }

        private static bool CheckIfNameExist(List<Person> PersonList, string SearchName)
        {
            return PersonList.Exists(person => person.Name.Equals(SearchName));
        }

        private static double RetrieveAverageAge(List<Person> PersonList)
        {
            return PersonList.Average(person => person.Age);
        }

        private static List<Person> RetrieveAllRecordsAgeBetween13And18(List<Person> PersonList)
        {
            PersonList.Sort((person1, person2) => person1.Age.CompareTo(person2.Age));
            return PersonList.FindAll(person => person.Age >= 13 && person.Age <= 18);        
        }
    }
}
