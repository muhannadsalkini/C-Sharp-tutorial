/*
 * ref funcktion: to change one paramiter by referanse address "works like pointers"
 * out funcktion: to change more than one paramiters, provides more than one output
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Functions
{
    internal class Program
    {
        /*************** call by value ****************/
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        /*************** ref ****************/
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; // temp = ref addres of x
            x = y; // ref of x = ref of y
            y = temp; // ref of y = temp
        }

        /*************** out ****************/
        public void getValue(out int x)
        {
            int temp = 5; // Change x to 5
            x = temp;
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        /*************** example 1 ****************/
        public void toplaCarp(int a, int b, out int add, out int multi)
        {
            add = a + b;
            multi = a * b;
        }

    }

    class test
    {
        static void Main(string[] args)
        {
            /*************** call by value ****************/

            //Program program = new Program(); // New object

            //int a = 100;
            //int b = 200;

            //Console.WriteLine("Enter the first number : ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number : ");
            //b = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Max value is : {0}", program.FindMax(a, b)); // Call function by value

            //Console.ReadKey();


            /*************** ref ****************/

            //Program program = new Program(); // New object

            //int a = 100;
            //int b = 200;

            //Console.WriteLine("Before swap, value of a : {0}", a);
            //Console.WriteLine("Before swap, value of b : {0}\n", b);

            //program.swap(ref a, ref b); // Call by refrans "Like pointers"

            //Console.WriteLine("After swap, value of a : {0}", a);
            //Console.WriteLine("After swap, value of b : {0}", b);

            //Console.ReadKey();


            /*************** out ****************/

            //Program program = new Program(); // New object

            //int a = 100;
            //int b = 200;

            //Console.WriteLine("Before method call, value of a : {0}", a);
            //program.getValue(out a); // One paramiter
            //Console.WriteLine("After method call, value of a : {0}", a);


            //program.getValues(out a, out b); // Tow paramiters
            //Console.WriteLine("After method call, value of a : {0}", a);
            //Console.WriteLine("After method call, value of b : {0}", b);

            //Console.ReadKey();

            /*************** example 1 ****************/
            /* Write a function that returs a sum and multiply of tow numbers using out or ref. */

            //Program program = new Program(); // New object

            //int a, b;
            //int add, multi;


            //Console.WriteLine("Enter the first value: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second value: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //program.toplaCarp(a, b, out add, out multi);

            //Console.WriteLine("Result of sum is: {0} and result of multiply is {1}", add, multi);

            //Console.ReadKey();


            /*************** DateTime ****************/

            //DateTime dt = new DateTime(); // Assigns default value 01.01.0001 00:00:00
            //Console.WriteLine(dt);
            
            //DateTime myBirthDate = new DateTime(2002, 01, 26); // Assigns year, month, day
            //Console.WriteLine(myBirthDate);

            //DateTime Dtclock = DateTime.Now;
            //Console.WriteLine(Dtclock.Hour +":"+ Dtclock.Minute);

            //DateTime dt2 = new DateTime(2019, 11, 23, 5, 10, 20); //Assigns year, month, day, hour, min, seconds
            //Console.WriteLine(dt2);
            
            //DateTime dt3 = new DateTime(2019, 12, 31, 5, 10, 20, DateTimeKind.Utc); // Assigns y, m, d, h, m, s, UTC timezone
            //Console.WriteLine(dt3);

            //Console.ReadKey();


            /*************** TimeSpan ****************/

            //DateTime dt4 = new DateTime(2015, 12, 31);
            //TimeSpan ts = new TimeSpan(25, 20, 55);
            //DateTime newDate = dt4.Add(ts);
            //Console.WriteLine(newDate);

            //Console.ReadKey();


            /*************** example 2 ****************/

            //string myBirthDate = "26/01/20022";
            //DateTime dt;
            //var isValidDate = DateTime.TryParse(myBirthDate, out dt);

            //DateTime Dtclock = DateTime.Now;

            //Console.WriteLine(Dtclock - myBirthDate);

            //Console.ReadKey();


        }
    }
}
