using System;

namespace BasicConsoleApp
{
    internal class Program
    {
        /* 
         Create a simple console application in C# that asks for a user's name and outputs a greeting
        message with the entered name. Extend it and create a simple calculator: Develop a console-based 
        calculator application. The application should support basic operations like addition, subtraction,
        multiplication, and division. 
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            string UserName = Console.ReadLine();
            Console.WriteLine("Hi {0}, Welcome To Our Application...", UserName);

            string IsContinue = "";
            string ToProceed = "";
            int FirstNumber = 0;
            int SecondNumber = 0;

            try
            {
                do
                {
                    Console.WriteLine("Please Enter First Number...");
                    string FirstInput = Console.ReadLine();
                    Console.WriteLine("Please Enter Second Number...");
                    string SecondInput = Console.ReadLine();

                    bool IsFirstNumberValid = int.TryParse(FirstInput, out FirstNumber);
                    bool IsSecondNumberValid = int.TryParse(SecondInput, out SecondNumber);

                    if (IsFirstNumberValid && IsSecondNumberValid )
                    {
                       
                            Console.WriteLine("Press 1 : Addition");
                            Console.WriteLine("Press 2 : Subtraction");
                            Console.WriteLine("Press 3 : Multiplication");
                            Console.WriteLine("Press 4 : Division");

                            short choice = Convert.ToInt16(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Sum Of {0} & {1} = {2}", FirstNumber, SecondNumber, FirstNumber + SecondNumber);
                                    break;
                                case 2:
                                    Console.WriteLine("Subtraction Of {0} & {1} = {2}", FirstNumber, SecondNumber, FirstNumber - SecondNumber);
                                    break;
                                case 3:
                                    Console.WriteLine("Multiplication Of {0} & {1} = {2}", FirstNumber, SecondNumber, FirstNumber * SecondNumber);
                                    break;

                                case 4:
                                    Console.WriteLine("Division Of {0} & {1} = {2}", FirstNumber, SecondNumber, FirstNumber / SecondNumber);
                                    break;

                                default:
                                    Console.WriteLine("You Have Entered Wrong Choice...");
                                    break;
                            }
               
                    }
                    else
                    {
                        Console.WriteLine("Either/Both of {0} or {1} is not a number", FirstInput,SecondInput);
                        Console.WriteLine("Please Try Again");
                    }
                    IsContinue = ToContinue();
                } while (IsContinue.ToUpper() == "Y");

            }
            catch(Exception e) {
                Console.WriteLine("Exception : " + e.Message);
            }
            finally {
                Console.WriteLine("Application Completed Successfully");
            }
        }

        public static string ToContinue()
        {
            Console.WriteLine("Press Y for continue and Anything to exit?");
            string isContinue = Console.ReadLine();
            return isContinue;
        }
    }
}
