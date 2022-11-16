using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_
{
    internal class Person
    {
        private string name;  // field

        public string GetSetName    // property
        {
            set { name = value; } // set => name = value;
            get { return name; } // get => name;
        }

        //public string getName()
        //{
        //    return name;
        //}

        //public void setName(string name)
        //{
        //    this.name = name;
        //}

    }
}
