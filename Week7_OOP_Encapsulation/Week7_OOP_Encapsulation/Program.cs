using Encapsulation_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person Class
            Person P1 = new Person();
            P1.Name = "Ahmet"; // For private name
            P1.Namee = "Mehmet"; // For Public name
            //Console.WriteLine("Private name = {0}", P1.Name);
            //Console.WriteLine("Public name = {0}", P1.Namee);
            //Console.ReadKey();


            // Student Class
            Student S1 = new Student();
            S1.setStudent_name("Mahmut");
            //Console.WriteLine("Studnet name = {0}" ,S1.getStudent_name());
            //Console.ReadKey();


            // Customer Class
            Customer C1 = new Customer();
            C1.C_weight_Property = 50;
            Console.WriteLine("Person weight" + C1.C_weight_Property);
            Console.ReadKey();
        }
    }
}
