using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_OOP_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel(1, "Muhannad", "Salkini");

            Personel.salary = 5000;

            //Console.WriteLine("ID = {0}, Name: {1} {2}, Salary: {3}"
            //    , P1.p_id, P1.name, P1.s_name, Personel.salary);

            //Personel.claculate_Salary(100);

            //Console.WriteLine("ID = {0}, Name: {1} {2}, New Salary: {3}"
            //    , P1.p_id, P1.name, P1.s_name, Personel.salary);

            Personel P2 = new Personel("Male");
            P2.P_show();

            Console.ReadKey();
        }
    }
}
