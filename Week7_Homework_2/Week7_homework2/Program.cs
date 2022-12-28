using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel("Muhannad", "Salkini", "1234567a901");

            Console.WriteLine("TC: {0}",p1.tc);
            Console.ReadKey();
        }
    }
}
