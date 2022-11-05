using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Arrays
{
    internal class Program
    {
        double getAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }

         void kupAl(int[] arry)
        {
            int[] arry2 = new int[arry.Length];
            for (int i = 0; i < arry.Length; i++)
            {
                arry2[i]= (int)Math.Pow(arry[i], 3);
            }
        }

        static void Main(string[] args)
        {
            Program app = new Program();
            int[] arry = { 8, 1, 5, 3, 9, 2, 6, 7, 1, 4 };
            app.kupAl(arry);

            foreach (int i in arry)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

            /*********************/

            //int[] arry = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };
            //int result =0 ;

            //for (int i = 0; i < 10; i++ )
            //{
            //    result = result + arry[i];
            //    Console.WriteLine("Element [{0}] = {1} ",i,arry[i]);
            //}
            //Console.WriteLine("Result = {0}",result);
            //Console.ReadKey();

            /*********************/

            //Program app = new Program();
            //int[] balance = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //Console.WriteLine("Average value is: {0} ", app.getAverage(balance));
            //Console.ReadKey();

            /***********************/

            //int[] list = { 1, 5, 7, 9, 2, 6, 3, 8, 4 };
            //int[] arr = list;

            //Console.Write("Array: ");
            //foreach (int i in list)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //// reverse the array
            //Array.Reverse(arr);
            //Console.Write("Reversed Array: ");
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            ////sort the array
            //Array.Sort(list);
            //Console.Write("Sorted Array: ");
            //foreach (int i in list)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //// powr of the largest number
            //int lrgest = list[8];

            //Console.Write("Power of last: ");
            //Math.Pow(lrgest, 2);
            //Console.WriteLine(Math.Pow(lrgest, 2));
            //Console.ReadKey();

            /***********************/

            //int[] arry = { 8, 1, 5, 3, 9, 2, 6, 7, 1, 4 };
            //string[] arry2 = new string[10];

            //// original array
            //Console.Write("Original Array: ");
            //foreach (int i in arry)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //// sort yhe arry
            //Array.Sort(arry);

            //// reverse the array
            //Array.Reverse(arry);
            //Console.Write("Reversed Array: ");
            //foreach (int i in arry)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //// convert to string
            //Console.Write("String Array: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    arry2[i] = Convert.ToString(arry[i]);
            //}
            //foreach (string i in arry2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.Write("Enter the number: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("the {0} element of the array is: {1}",a,arry[a]);

            //Console.ReadKey();

            /***********************/



        }
    }
}
