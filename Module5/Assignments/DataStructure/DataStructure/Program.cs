using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace DataStructure
{
    internal class Program
    {
        /*
         Write a program that uses different data structures (like arrays, lists, and dictionaries) in C# to
        store and manipulate a set of data. For example, you could create a list of different cars and their
        properties (make, model, year, etc.). 
         
         */
        static void Main(string[] args)
        {

            Car[] ArrayOfCars = new Car[3];
            Car C1 = new Car("TATA", "TIAGO", 2020);
            Car C2 = new Car("TATA", "SUMO", 2004);
            Car C3 = new Car("TATA", "FORTUNER", 2010);
            Car C4 = new Car("TATA", "PUNCH", 2022);

            ArrayOfCars[0] = C1;
            ArrayOfCars[1] = C2;
            ArrayOfCars[2] = C3;

            foreach (Car car in ArrayOfCars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("............AFTER MODIFYING 0th INDEX OF AN ARRAY..............");

            ArrayOfCars[0] = C4;

            foreach(Car car in ArrayOfCars)
            {
                Console.WriteLine(car.ToString());
            }

            List<Car> ListOfCars = ArrayOfCars.ToList();
            Console.WriteLine("............AFTER CONVERTING ARRAY INTO AN LIST..............");
            foreach (Car car in ListOfCars)
            {
                Console.WriteLine(car.ToString());
            }

            List<Car> ListOfCarsAfter2015Manufacturing = ListOfCars.FindAll((item) => item.Year >= 2010);

            Console.WriteLine("----------List Of Cars with Manufacturing Year > 2015------------");

            foreach(Car car in ListOfCarsAfter2015Manufacturing)
            {
                Console.WriteLine(car.ToString());
            }

            Dictionary<String,Car> DictionaryOfCars = ArrayOfCars.ToDictionary((item) => item.Model);

            Console.WriteLine("............AFTER CONVERTING ARRAY INTO AN DICTIONARY..............");
            foreach (KeyValuePair<string,Car> keyValuePair in DictionaryOfCars)
            {
                Car C = keyValuePair.Value;
                Console.Write("KEY : "+ keyValuePair.Key+ " ---> ");
                Console.WriteLine(C.ToString());
            }

            Console.WriteLine("Count of items in dictionary id {0} ", DictionaryOfCars.Count);

            if(DictionaryOfCars.Remove(C4.Model))
            {
                Console.WriteLine("Key With {0} Dictionary Object Deleted Successfully...", C4.Model);
            }

            Console.WriteLine("------REMOVING ALL DICTIONARY OBJECTS------------");
            DictionaryOfCars.Clear();
        }
    }

    public class Car
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set;}

        public Car(string Manufacturer, string Model, int Year)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.Year = Year;
        }

        public override string ToString()
        {
            return "[ Manufacture : "+this.Manufacturer+ ", Model : "+this.Model+", Year : "+this.Year+ "]";
        }
    }
}
