using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do - While Operator

            int i = 0;

            do
            {
                i++;
                if ((i % 2) != 0)
                {
                    continue;
                }

                Console.WriteLine("i = {0}", i);

            }
            while (i < 20);

            Console.ReadKey();
        }
    }
}
