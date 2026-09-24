using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate() : this(0, 0, 0) //Default Constructor
        { }     
        public HiringDate(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y;
        }

        public override string ToString()
        {
            return $"{Day}-{Month}-{Year}";
        }
    }
}
