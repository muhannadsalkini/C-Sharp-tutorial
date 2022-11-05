using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_helloworld      // Birbiri ile ilgili alanlari bir arada toplamak icin namespace kullanilir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!") ;

            const double pi = 3.14159;
            double r;
            double CircleArea;

            Console.WriteLine("Enter The circle radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            CircleArea = r * r * pi;
            
            Console.WriteLine("Circle Area = " + CircleArea);
            Console.ReadKey();


            //string student_name = Console.ReadLine();
            //string student_surname = "Salkini";
            //int Student_no = 1910205563;

            //Console.WriteLine(student_name + " " + student_surname + ", " + Student_no) ;
            //Console.ReadKey();      // Bir tusa basana kadar cikti ekranda kalir

            //cls1 obj1 = new clas1(1,2);


        }
    }

    //class cls1
    //{
    //    private int num1;
    //    float num2 =5;

    //    public cls1(int num1, float num2)
    //    {
    //        this.num1 = num1;
    //        this.num2 = num2;
    //    }
    //}
}
