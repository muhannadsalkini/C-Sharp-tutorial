using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car C1 = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            C1.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(C1.brand + " " + C1.modelName);

        }
    }
}
