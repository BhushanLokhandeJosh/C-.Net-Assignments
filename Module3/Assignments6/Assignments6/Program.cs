using System;

namespace Assignments6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter You Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(Name, Age);
            person.IntroducePerson();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        private int _age;

        public int Age { 
            get { return _age; }
            set {
                if (value > 0)
                {
                    _age = value;
                }
                else throw new Exception("Please Enter A Valid Age");
                }

        }

        public Person(string Name,int Age) { 
        
            this.Name = Name;
            this.Age = Age;
        }

        public void IntroducePerson() {
            Console.WriteLine("Hello, My Name Is " + this.Name + ", and I am " + this.Age + " Years Old.");
        }

    }

}
