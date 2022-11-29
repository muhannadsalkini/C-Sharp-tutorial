using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week7_homework2
{
    internal class Personel
    {
        private string name;
        private string surname;
        private string TC;

        public Personel(string name, string surname, string TC)
        {
            this.name = name;
            this.surname = surname;
            tc = TC;
        }

        public string tc
        {
            get {
                if (TC != null)
                    return TC.Substring(0, 5)+"******";
                else
                    return "No TC number!";
            }
            set {
                if (value.Length == 11 && Regex.IsMatch(value, @"^\d+$")) // if TC is number and 11 charecter
                    TC = value;
                else
                    Console.WriteLine("Mising or worng data for TC!\n");
            }
        }
    }
}
