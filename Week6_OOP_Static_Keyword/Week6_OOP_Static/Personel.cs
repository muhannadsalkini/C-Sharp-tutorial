using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_OOP_Static
{
    public class Personel
    {
        public int p_id;
        public string name;
        public string s_name;
        public static int salary;

        public Personel(int p_id, string name, string s_name)
        {
            this.p_id = p_id;
            this.name = name;
            this.s_name = s_name;
        }
        public Personel(string Gender)
        {
            this.Gender = Gender;
        }
        public void P_show()
        {
            Console.WriteLine("Person informaion\n");
            Console.WriteLine("Gender: {0}, TC: {1}", Gender, P_TC);

        }

        static Personel()
        {
            P_TC = 123456789;
        }

        public static int claculate_Salary (int new_salary)
        {
            new_salary *= 100;
            return new_salary;
        }

        private static int P_TC { get; set; }

        private string Gender { get; set; }
    }
}
