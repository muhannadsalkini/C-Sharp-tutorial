using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine("value if i is: {0}", i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine("value if i is: {0}", i);
            }

            Console.ReadKey();
        }
    }
}
