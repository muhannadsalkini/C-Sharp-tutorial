using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11111111111111
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 45)
                Console.WriteLine("45'ten buyuk");
            else if (x < 45)
                Console.WriteLine("45'ten kucuk");
            else
                Console.WriteLine("45'e esit");

            // 2222222222222
            Console.WriteLine("Enter the first corner:");
            int corner1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second corner:");
            int corner2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the therd corner:");
            int corner3 = Convert.ToInt32(Console.ReadLine());

            if (corner1 == corner2 || corner1 == corner3 || corner2 == corner3)
                Console.WriteLine("ikizkenar");
            else if (corner1 == corner2 && corner2 == corner3)
                Console.WriteLine("eskenar");
            else
                Console.WriteLine("cesitkenar");

            // 333333333333333

            for(int i = 0; i < 100; i++)
            {
                if ((i % 2) != 0)
                    continue;
                else if (i == 60)
                    break;
                Console.WriteLine("i= {0}", i);
            }

            Console.ReadKey();

        }
    }
}
