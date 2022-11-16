using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using This_Keyword_Application;

namespace Week7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person Class
            Person P1 = new Person();
            P1.GetSetName = "Liam";
            Console.WriteLine(P1.GetSetName);
            Console.ReadKey();


            // Personal Class
            Personel Pe1 = new Personel("Male");
            //Pe1.P_show();
            //Console.ReadKey();
            

            // Information Class
            Information I1 = new Information(2, 3, 4);
            //I1.Calculate();
            //Console.ReadKey();


        }
    }


}
