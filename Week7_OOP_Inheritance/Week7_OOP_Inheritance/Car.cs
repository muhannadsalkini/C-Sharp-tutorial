using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_OOP_Inheritance
{
    sealed class Car : Vehicle // Derived class (Chiled)
    {
        public string modelName = "Mustang";  // Car field
    }
}

// Car class have the inherited varables from Vehicle class and have its own varables
// If you don't want other classes to inherit from a class, use the "sealed" keyword.
