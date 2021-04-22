using System;

namespace w3school_c__OOP_Concepts
{
    class Program
    {
        static int addition(int x,int y){
            return x + y;
        }
        static double addition(double x,double y){
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(addition(1,1));
            System.Console.WriteLine(addition(1.234,5.234));
            Console.ReadLine();
        }
    }
}
