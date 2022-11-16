using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Application
{
    class Student
    {
        private string Student_name;

        public void setStudent_name(string Student_name)
        {
            this.Student_name = Student_name;
        }

        public string getStudent_name()
        {
            return Student_name;
        }
    }
}

