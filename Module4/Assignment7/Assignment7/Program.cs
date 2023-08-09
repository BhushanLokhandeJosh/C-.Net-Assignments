using System;
using System.IO;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            StreamReader sr = null;
            string line;
            try
            {
                sw = new StreamWriter("C:\\Bhushan Data\\Csharp-.Net-Assignments\\TestReadWrite.txt");

                Console.WriteLine("Enter Your Full Name");

                sw.WriteLine(Console.ReadLine());

                Console.WriteLine("Where Do You Belongs To");

                sw.WriteLine(Console.ReadLine());               

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
               sw.Close();
               Console.WriteLine("Closing StreamWriter Connection...");
                
            }

            try
            {
                sr = new StreamReader("C:\\Bhushan Data\\Csharp-.Net-Assignments\\TestReadWrite.txt");

                line = sr.ReadLine();

                Console.WriteLine(".................Reading File..............");

                while (line != null)
                {

                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }

                Console.WriteLine("Reading File Completed");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally 
            {
                sr.Close();

                Console.WriteLine("Closing StreamReader Connection...");
            }
        }
    }
}
