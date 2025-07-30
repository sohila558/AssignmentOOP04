using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        // Ooperator overloading
        // +
        // Must Be : Public Static

        // Binary : + - * / % 

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
    }
}
