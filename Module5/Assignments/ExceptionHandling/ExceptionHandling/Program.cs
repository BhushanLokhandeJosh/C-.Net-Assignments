using System;

namespace ExceptionHandling
{
    internal class Program
    {
        /* 
         Exception Handling: Extend the calculator application to handle potential errors,
        such as division by zero or input of non-numeric characters.
         
         */
        static void Main(string[] args)
        {
            string IsContinue = "";
           
            try
            {
                do
                {
                    Console.WriteLine("Please Enter First Number...");
                    int FirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter Second Number...");
                    int SecondNumber = Convert.ToInt32(Console.ReadLine());

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

                    IsContinue = ToContinue();
                } while (IsContinue.ToUpper() == "Y");

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("You Can't Divide By Zero...");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entered Input is Not In Number Format...");
            }
            catch(OverflowException)
            {
                Console.WriteLine("For an Int32 Number should Be lies between {0} and {1}",int.MinValue,int.MaxValue);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.ToString());
            }
            finally
            {
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
