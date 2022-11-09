// chapter 13
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Math
{
    internal class Program
    {
        public void calculate (int[] arry, ref int[] arry2)
        {
            foreach(int i in arry)
            {
                Console.WriteLine(arry[i]);
                arry2[i] = (int)Math.Pow(arry[i], 3);
            }
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            //double e = Math.E; // Find E constant values
            //Console.WriteLine("Math.E = " + e);
            
            //double pi_value = Math.PI; // Find PI constant values
            //Console.WriteLine("Math.PI = " + pi_value);

            int[] arry = { 1, 2, 3, 4, 5, 6};

            int[] arry2 = { 1, 2, 3, 4, 5, 6};

            program.calculate( arry, ref arry2);

            Console.WriteLine("first arry is: {0}\n" , arry);
            Console.WriteLine("secound arry is: {0}" , arry2);
            Console.ReadKey();
        }
    }
}
