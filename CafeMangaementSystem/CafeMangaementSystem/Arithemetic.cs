using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class Arithemetic
    {
        //properties
        private double first = 0;
        private double second = 0;

        //constructor
        public Arithemetic(double first, double second)
        {
            this.first = first;
            this.second = second;
        }

        //behaviour
        public double Add()
        {
            return first + second;
        }

        public double Sub()
        {
            return first - second;
        }

        public double Mul()
        {
            return first * second;
        }
        public double Div()
        {
            return first / second;
        }
    }
}
