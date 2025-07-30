using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal static class Utilities
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        private static double pi = 3.14;

        //public Utilities()
        //{
        //    pi = 3.14;
        //}

        static Utilities() 
        {
            pi = 3.14;
        }

        public static double CaToInch(double cm)
        {
            return cm / 2.54;
        }

        public static double PI
        {
            get
            {
                return pi;
            }
        }
    }
}
