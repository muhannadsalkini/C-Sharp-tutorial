using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_enumm
{
    internal class Program
    {
        enum calisanlar : byte
        {
            idareci,
            ogretmen,
            memur,
            hizmetci
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 - 3: ");
            byte num = Convert.ToByte(Console.ReadLine());


            switch (num)
            {
                case 0:
                    Console.WriteLine("{0} maasi = 15000", calisanlar.idareci);
                    break;
                case 1:
                    Console.WriteLine("{0} maasi = 9000", calisanlar.ogretmen);
                    break;
                case 2:
                    Console.WriteLine("{0} maasi = 7000", calisanlar.memur);
                    break;
                case 3:
                    Console.WriteLine("{0} maasi = 5500", calisanlar.hizmetci);
                    break;
               default:
                    Console.WriteLine("Please enter a number between 0 - 3! ");
                    break;
            }
            
            Console.ReadKey();
               
        }
    }
}
