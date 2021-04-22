using System;

namespace w3school_c__OOP_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car01 = new Car("civic","grey",1995);
            // 'Car.year' is inaccessible due to its protection level
            // System.Console.WriteLine(car01.year);
            car01.getCarDetails();
            Console.ReadLine();
        }
    }
}
