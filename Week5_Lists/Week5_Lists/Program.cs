using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Week5_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*************** ArryList **************/

            //// None generetic 
            //// Create an ArrayList
            //ArrayList list_3 = new ArrayList();  
            //// or
            ////var list_1 = new ArrayList();


            //// Aadding elements into arrylist
            //list_3.Add(1);
            //list_3.Add("Bill");
            //list_3.Add(" ");
            //list_3.Add(true);
            //list_3.Add(4.5);
            //list_3.Add(null);

            //var list_1 = new ArrayList();
            //var list_2 = new ArrayList()
            //{
            //    1, "Bill", " ", true, 4.5, null
            //};
            //int[] arr = { 100, 200, 300, 400 };

            //Queue myQ = new Queue(); // create Queue
            //myQ.Enqueue("Hellow");
            //myQ.Enqueue("World!");

            //list_1.AddRange(list_2); //adding list_2 arraylist in list_1 arraylist
            //list_1.AddRange(arr); //adding array in arraylist
            //list_1.AddRange(myQ); //adding Queue in arraylist


            //// Print arrayList
            //foreach (var item in list_1)
            //    Console.Write(item + ", ");


            //// Insert: To add one varable "list_1.Insert(1, "Second Item");"
            //// InsertRange: To add between one or more varable
            //ArrayList arlist1 = new ArrayList()
            //{
            //    100, 200, 600
            //};
            //ArrayList arlist2 = new ArrayList()
            //{
            //    300, 400, 500
            //};
            //arlist1.InsertRange(2, arlist2);
            //foreach (var item in arlist1)
            //    Console.Write(item + ", "); //output: 100, 200, 300, 400, 500, 600,


            //// Remove Elements from ArrayList
            ////list_1.Remove(null); //Removes first occurance of null
            ////list_1.RemoveAt(4); //Removes element at index 4
            ////list_1.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)


            //Console.ReadKey();

            /*************** example 1 **************/
            Queue p1 = new Queue()
            {

            }

            var users = new ArrayList()
            {
                1,
                "ahmet mehmet",
                "7/10/1974",

                2,
                "mahmut mehmet",
                "7/10/1974",

                3,
                "muhannad salkini",
                "7/10/1974",

                4,
                "majd salkini",
                "7/10/1974",

                5,
                "abdullah salkini",
                "7/10/1974",

            };

            for (int i = 0; i < users.Count; i++)
            {

            }
                
            foreach (var item in users)
            {
                Console.Write(item + ", ");
            }

            Console.ReadKey();

        }
    }
}
