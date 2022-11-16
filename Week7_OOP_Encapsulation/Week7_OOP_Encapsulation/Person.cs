using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Application
{
    class Person
    {
        private string name;
        public string Name // Set values for private name varable
        { 
            get => name; // get {return name}
            set => name = value;  // set {name = value}
        }

        public string Namee    // Set values for Public Namee
        { get; set; }

    }
}

