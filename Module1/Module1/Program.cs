using System;
using System.Text.RegularExpressions;

namespace Module1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Assignment 1.
             Introduction to C# - "Hello, {{Day in String}}!"  Create a simple console application that prints
            "Hello, Monday(this should be depend on current date and day)!" on the console screen.
             */
            DateTime CurrentDate = DateTime.Now;
            DayOfWeek CurrentDay = CurrentDate.DayOfWeek;
            Console.WriteLine("Hello, {0}", CurrentDay);

            /* Assignment 2
             Variables and User Input : Develop a console application that takes a user's name as input and greets
            them by their name. Ensure That the Name entered in string only. Validate and through error if enter 
            anything apart from string chars.
             */

            Console.WriteLine("Please Enter Your Name!");
            string UserName = Console.ReadLine();

            if (!Regex.IsMatch(UserName, @"^[a-zA-Z]+$"))
            {
                throw new Exception("Incorrect UserName Format...");
            } else
            {
                Console.WriteLine("Hello, {0}", UserName);
            }
        }
    }
}
