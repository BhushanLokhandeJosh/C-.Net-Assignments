using System;
using System.Collections.Generic;

namespace Assignment5
{
    /*
    Working with Arrays : Develop a console application that sorts an array of integers 
    in ascending order or descending order based on users input. In Another assignment 
    accept array of objects and perform at least 4 array operations.  
 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] IntegerArrays = new int[] { 45, 32, 12, 76, 8, 90, 67 };
            Console.WriteLine("Before Sorting...");
            foreach (int integer in IntegerArrays)
            {
                Console.Write(" - " + integer);
            }

            Array.Sort(IntegerArrays);
            Console.WriteLine();
            Console.WriteLine("After Sorting...");
            foreach (int integer in IntegerArrays)
            {
                Console.Write(" - " + integer);
            }

            Person P1 = new Person() { Id = 101, Name = "Bhushan", Age = 18 };

            Person P2 = new Person() { Id = 202, Name = "Jayesh", Age = 25 };

            Person P3 = new Person() { Id = 303, Name = "Yogesh", Age = 17 };

            Person P4 = new Person() { Id = 404, Name = "Mahesh", Age = 22 };

            List<Person> PersonsList = new List<Person>();

            Console.WriteLine();

            Console.WriteLine(".................USING ADD METHOD ON LIST............");

            PersonsList.Add(P1);
            PersonsList.Add(P2);
            PersonsList.Add(P3);

            Console.WriteLine("...............AFTER ADDING 3 PERSON OBEJECTS INTO List<Person>...........");
            foreach (Person person in PersonsList)
            {
                Console.WriteLine("Person Id : {0} , Name : {1} , Age : {2}", person.Id, person.Name, person.Age);
            }

            if (PersonsList.Contains(P1))
            {
                Console.WriteLine(".................USING CONTAINS METHOD ON LIST............");
                Console.WriteLine("Person With Id : {0} Is Present In List...", P1.Id);
            }

            Console.WriteLine(".................USING INSERT METHOD ON LIST............");
            PersonsList.Insert(0, P4);
            foreach (Person person in PersonsList)
            {
                Console.WriteLine("Person Id : {0} , Name : {1} , Age : {2}", person.Id, person.Name, person.Age);
            }

            Console.WriteLine(".................USING SORT BY AGE IN ASCENDING ORDER............");

            PersonsList.Sort((P1, P2) => P1.Age.CompareTo(P2.Age));

            foreach (Person person in PersonsList)
            {
                Console.WriteLine("Person Id : {0} , Name : {1} , Age : {2}", person.Id, person.Name, person.Age);
            }

            Console.WriteLine(".................USING FIND TO FIND PERSON WHO CAN VOTE ( >= 18 AGE )............");
            List<Person> PersonVotingList = PersonsList.FindAll((listItem) => listItem.Age >= 18);
            foreach (Person person in PersonVotingList)
            {
                Console.WriteLine("Person Id : {0} , Name : {1} , Age : {2}", person.Id, person.Name, person.Age);
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (_age < 0)
                {
                    throw new Exception("Age Can't be negative...");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public int CompareTo(Person obj)
        {
            if (obj != null)
            {

                return Age.CompareTo(obj.Age);

            }
            else
                throw new NotImplementedException();
        }
    }
}
