using System;

namespace ClassAndObject
{
    internal class Program
    {
        /* 
         Create a class for a 'Student' with properties like 'Name', 'Age', 'Grade', etc. Create objects 
        of this class and manipulate them. Extend this and used Inheritance to create a 'CollegeStudent'
        class that inherits from your 'Student' class and adds college-specific properties.
         
         */
        static void Main(string[] args)
        {
            try
            {
                Student Student = new Student(22, "Bhushan", 89);
                Console.WriteLine("....Student Class Object....");
                Console.WriteLine(Student.ToString());

                Student Student2 = Student;
                Student2.Name = "Jayesh";
                Student2.Age = 30;
                Student2.Grade = 50;
                Console.WriteLine("....Student Class Object After Manipulation....");
                Console.WriteLine(Student.ToString());

                CollegeStudent CollegeStudent = new CollegeStudent(23, "Yogesh", 88, "DBATU,Lonere");
                Console.WriteLine("....CollegeStudent Class Object....");
                Console.WriteLine(CollegeStudent.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception "+ ex.Message);
            }
            finally
            {
                Console.WriteLine(".......Application Completed Successfully......");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }

        private int _age;

        private int _grade;

        public int Age { 
            get { return _age; } 
            set { 
                if( value > 0 && value <= 100 )
                {
                    _age = value;
                } else
                {
                    throw new Exception("Age Cann't be Negative...");
                }
            } 
        }

        public int Grade
        {
            get { return _grade; }
            set
            {
                if(value > 0 && value <= 100 ) { _grade = value; } 
                else { throw new Exception("Grade Cann't be negative."); }
            }
        }

        public Student(int Age,string Name,int Grade) {
            this.Age = Age;
            this.Name = Name;
            this.Grade = Grade;
        }

        public override string ToString()
        {
            return "[ NAME : "+this.Name+", AGE : "+this.Age+", Grade : "+this.Grade+"]";
        }
    }

    internal class CollegeStudent : Student
    {
        
        public string CollegeName { get; set; }

        public CollegeStudent(int Age, string Name, int Grade,string CollegeName) : base(Age, Name, Grade)
        {
            this.CollegeName = CollegeName;
        }

        public override string ToString()
        {
            return "[ NAME : " + this.Name + ", AGE : " + this.Age + ", Grade : " + this.Grade +", College Name : " + this.CollegeName +"]";
        }

    }
}
