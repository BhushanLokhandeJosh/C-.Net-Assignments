using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Module2
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            /* 
             Write a console application that takes an integer as input and  show at least 4
            operations  which can be perform on it.  for e.g 1) input number then outputs whether
            the number is even or odd. 2) Whether its prime number .
             */

            try
            {
            Operation:
                Console.WriteLine("Enter a number");
                string readInput = Console.ReadLine();
                int inputNumber;

                Student[] Students;
                int StudentIndex = 0;

                bool checkIsNumber = int.TryParse(readInput, out inputNumber);
                if (checkIsNumber)
                {
                        Console.WriteLine("Press 1 : Check Odd Or Even");
                        Console.WriteLine("Press 2 : Check Prime Number or not");
                        Console.WriteLine("Press 3 : To Enter {0} Student Details...", inputNumber);
                        Console.WriteLine("Press 4 : Enter Id Of Student To Check whether he can cast a vote...");

                        short choice = Convert.ToInt16(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                if (inputNumber % 2 == 0)
                                {
                                    Console.WriteLine("{0} Number Is Even", inputNumber);
                                }
                                else
                                {
                                    Console.WriteLine("{0} Number Is Odd", inputNumber);
                                }
                                break;

                            case 2:
                                bool flag = false;
                                for (int i = 2; i <= inputNumber / 2; ++i)
                                {
                                    if (inputNumber % i == 0)
                                    {
                                        flag = true;
                                        break;
                                    }
                                }

                                if (!flag)
                                    Console.WriteLine(inputNumber + " is a prime number.");
                                else
                                    Console.WriteLine(inputNumber + " is not a prime number.");
                            break;

                            case 3:
                      
                            Students = new Student[inputNumber];

                            StudentDetails:
                            Console.WriteLine("Enter Student Id");
                            int Id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Student Name");
                            string Name = Console.ReadLine();

                            Console.WriteLine("Enter Student Age");
                            int Age = Convert.ToInt32(Console.ReadLine());

                            Student newStudent = new Student(Id, Name, Age);
                            Students[StudentIndex] = newStudent;
                            StudentIndex++;
                            Console.WriteLine("You Have Successfully Entered Student Details...");
                            if (StudentIndex == inputNumber)
                            {
                                Dictionary<int,Student> StudentKeyValue = Students.ToDictionary(stud => stud.Id);
                                foreach (KeyValuePair<int,Student> student in StudentKeyValue)
                                {
                                    Student C = student.Value;
                                    Console.WriteLine("Key is : {0} , Name : {1} , Age : {2}", student.Key,C.Name,C.Age);
                                }
                                break;
                            }
                            else
                                goto StudentDetails;

                            default:
                                Console.WriteLine("No Operation Exists For Given Input...");
                                break;
                        }

                        Console.WriteLine("Press Y for continue and Anything to exit?");
                        string isContinue = Console.ReadLine();
                        switch(isContinue.ToUpper()) {
                            case "Y":
                                goto Operation;
                            default:
                                Console.WriteLine("Operation Completed...");
                                break;
                        }
                    }
                else
                {
                  
                    Console.WriteLine("{0} is not a number", readInput);
                    Console.WriteLine("Please Try Again");
                    goto Operation;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
   
        }
    }

    class Student
    {
        private int _id;

        private string _name;

        private int _age;

        public int Id
        {
            get { return _id ; } 
            
            set {

                if (_id >= 0)
                    _id = value;
                else
                    throw new Exception("Student Id Can't be Negative");
                        
            }
        }

        public string Name
        {
            get { return _name ; }
            set {

                if (_name.Trim() == "")
                    throw new Exception("Student Name Can't be Blank");
                else
                    _name = value;
                
            }
        }

        public int Age
        {
            get { return _age; }

            set
            {

                if (_age >= 0)
                    _age = value;
                else
                    throw new Exception("Age Can't be Negative");

            }
        }

        public Student(int Id,string Name,int Age) {
        
            this._id = Id ;
            this._name = Name;
            this._age = Age;
        }

    }

}
