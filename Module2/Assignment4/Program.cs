using System;
using System.Xml.Serialization;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Choice = null;
                do
                {
                    Console.WriteLine("Enter a number whose Factorial You Want To Know ...");
                    int number = Convert.ToInt32(Console.ReadLine());
                    long factorial = NumberFactorial(number);
                    Console.WriteLine(factorial);
                    Console.WriteLine("Factorial of {0} = {1}", number, factorial);
                    Console.WriteLine("Do You Want To Continue ?...Press Y for Yes And Press Anything To Quit...");
                    Choice = Console.ReadLine();
                }
                while (Choice.ToUpper() == "Y");
            } 
            catch(Exception e) 
            { 
                Console.WriteLine("Exception" + e.Message);
            } 
            finally 
            {
                Console.WriteLine("Thank You For Using Our Application...");
            }
        }

        public static long NumberFactorial(int number)
        {
            if (number >= 1)
            {
                return number * NumberFactorial(number - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
