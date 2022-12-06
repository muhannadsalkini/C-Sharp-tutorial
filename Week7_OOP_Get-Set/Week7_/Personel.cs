using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_
{
    internal class Personel
    {
        private static int TC { get; set; }
        private string Gender { get; set; }

        static Personel()
        {
            TC = 123456789;
        }
        public Personel(string gender)
        {
            this.Gender = gender;
        }

        public void P_show()
        {
            Console.WriteLine("Personal Information");
            Console.WriteLine("Person TC number: " + TC);
            Console.WriteLine("Person Gender: " + Gender);
        }

    }
}

namespace This_Keyword_Application
{
    class Information
    {
        public int x;
        public int y;
        public int z;

        public Information(int x)
        {
            this.x = x;
        }
        public Information(int x, int y, int z) : this(x)
        {
            this.y = y;
            this.z = z;
        }
        public void Calculate()
        {
            Console.WriteLine("Result is: \t" + (x + y + z));
        }

    }
}

