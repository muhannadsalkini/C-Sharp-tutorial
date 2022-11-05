using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_datatype_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int myInt = 100;
            //double myDouble = 2.25;
            //bool myBool = true;

            //double DoubleValue = 4.18;
            //int intValue = (int)DoubleValue;  // Manual casting: double to int

            //Console.WriteLine(DoubleValue);  // Output: 4.18
            //Console.WriteLine(intValue);  // Output: 4

            //Console.WriteLine(Convert.ToString(myInt));  // Convert int to string. Output: "100"
            //Console.WriteLine(Convert.ToDouble(myInt));  // Converi int to string. Output: 100
            //Console.WriteLine(Convert.ToInt32(myDouble));  //convert double to int. Output: 2
            //Console.WriteLine(Convert.ToString(myBool));  // convert bool to string. Output: "true"

            var i = 20;
            Console.WriteLine("tupe Of i is {0}", i.GetType().ToString());

            var str = "Hello World!";
            Console.WriteLine("tupe Of str is {0}", str.GetType().ToString());

            var d = 10.50d;
            Console.WriteLine("tupe Of d is {0}", d.GetType().ToString());



            Console.ReadKey();
        }
    }
}
