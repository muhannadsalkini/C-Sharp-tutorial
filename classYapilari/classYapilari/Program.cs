using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bread a = new Bread();
            a.counter = 5;
            Console.WriteLine("Bread: " + a.counter);

            butter.counter = 6;
            Console.WriteLine("Butter: " + butter.counter);
            Console.ReadKey();

        }
    }

    public class Bread
    {
        public int counter;
    }

     public static class butter
    {
        public static int counter;
    }
}
