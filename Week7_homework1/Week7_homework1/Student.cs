using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_homework1
{
    internal class Student
    {
        private int ogrenciNo;
        private string isim;
        private string soysim;
        private double vize1;
        private double vize2;
        private double final;
        private string okulIsmi;

        public Student(int ogrenciNo, string isim, string soysim, double vize1, double vize2, double final, string okulIsmi)
        {
            this.ogrenciNo = ogrenciNo;
            this.isim = isim;
            this.soysim = soysim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okulIsmi = okulIsmi;
        }

        public double ogrenciOrtalamasiBul()
        {
            return vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
        }

        public string okulGetir()
        {
            return okulIsmi;
        }

        public string ogrenciBilgileriGoster()
        {
            return isim +" "+ soysim;
        }


    }
}
