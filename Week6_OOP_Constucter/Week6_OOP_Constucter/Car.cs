using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_OOP_Constucter
{
    internal class Car
    {
        private string model;
        private int year;
        private string color;
        private int maxSpeed;

        public Car(string model, int year, string color, int maxSpeed)
        {
            this.model = model;
            this.year = year;
            this.color = color;
            this.maxSpeed = maxSpeed;
        }

        public Car(string model, int year, string color)
        {
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public Car() // Empty
        {

        }
        public void getModel(string model)
        {
            this.model = model;
        }
    }
}
