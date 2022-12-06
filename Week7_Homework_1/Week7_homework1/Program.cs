using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1910205563, "Muhannad", "Salkini", 100.00, 100.00, 100.00, "Karabuk Universitesi");

            int var =0;

            Console.WriteLine("1- Ogrenci Bilgileri Goster\n" +
                    "2- Ogrenci Ortalamasi Goster\n" +
                    "3- Ogrencinin Okuluni Ogren\n" +
                    "4- Cikis Yap\n");

            while (var != 4)
            {
                Console.WriteLine("Giris Yapin: ");
                var = Convert.ToInt32(Console.ReadLine());
                switch (var)
                {
                    case 1:
                        Console.WriteLine("Ad - Soyad: {0}\n", s1.ogrenciBilgileriGoster());
                        break;
                    case 2:
                        Console.WriteLine("Ortalama: {0}\n", s1.ogrenciOrtalamasiBul());
                        break;
                    case 3:
                        Console.WriteLine("Okul: {0}\n", s1.okulGetir());
                        break;
                    case 4:
                        Console.WriteLine("Cikis yapildi!\n");
                        break;
                    default:
                        Console.WriteLine("Hatali Giris Yapildi!\n");
                        break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
