using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ternary Operator: condition ? statement1 : statement2

            Console.WriteLine("Enter the x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y:");
            int y = Convert.ToInt32(Console.ReadLine());

            var result = x>y ? "x is greater than y" : "y is greater than x";

            Console.WriteLine(result);

            // same wit if - esle
            if (x > y)
                Console.WriteLine("x i greater than y");
            else
                Console.WriteLine("y is greater than x");

            


            
        }
    }
}
