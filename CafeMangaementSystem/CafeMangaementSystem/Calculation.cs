using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class Calculation
    {
        //properties

        private int first;
        private int second;

        //getter and setter for both numbers

        public int _first
        {
            get { return first; }
            set { first = value; }
        }
        public int _second
        {
            get { return second; }
            set { second = value; }
        }

        public int add()
        {
            return first + second;
        }

    }
}
