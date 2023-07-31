using System;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindFactorial:
            Console.WriteLine("Enter a number ...");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = NumberFactorial(number);
            Console.WriteLine(factorial);
            Console.WriteLine("Factorial of {0} : {1}", number, factorial);
            Console.WriteLine("Do You Want To Continue...Press Y for Yes...");
            string Choice = Console.ReadLine();
            switch (Choice.ToUpper())
            {
                case "Y":
                    goto FindFactorial;
                default:
                    break;
            }
            Console.WriteLine("Thank You...");
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
