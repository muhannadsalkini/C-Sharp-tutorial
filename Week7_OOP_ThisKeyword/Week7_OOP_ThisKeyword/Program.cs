using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using This_Keyword_Application;

namespace Week7_OOP_ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Personal Class
            Personel P1 = new Personel("Male");
            //P1.P_show();
            //Console.ReadKey();


            // Information Class
            Information I1 = new Information(2, 3, 4);
            I1.Calculate();
            Console.ReadKey();
        }
    }
}


