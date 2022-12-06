using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_OOP
{
    internal class Program
    {
        string color = "red";
        string model;
        int year;
        int maxSpeed = 200;
        void fullTrouttle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        static void Main(string[] args)
        {
            Car obj1 = new Car();
            //Console.WriteLine(obj1.color);

            Program obj2 = new Program();
            //Console.WriteLine(obj2.color);
            //Console.WriteLine(obj2.maxSpeed);
            //obj2.fullTrouttle();

            Program Ford = new Program();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Program Opel = new Program();
            Opel.model = "Astra";
            Opel.color = "blue";
            Opel.year = 2006;

            obj1.fullTrouttle();

            Console.ReadKey();
        }
    }
}
