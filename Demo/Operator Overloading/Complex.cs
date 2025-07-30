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


        // Operator Overloading
        // ++ -- 
        // Function : public - static 

        // Unary Operator ++ --

        public static Complex operator ++(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real++;
                return complex;
            }
            else
                return new Complex();
        }
        public static Complex operator --(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real--;
                return complex;
            }
            else
                return new Complex();
        }

        // Compraison Operator < > <= >= != == 
        // Return Type must be boolean

        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag > right.Imag;
            return left.Real > right.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;
            return left.Real < right.Real;
        }

        public static bool operator >=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag >= right.Imag;
            return left.Real >= right.Real;
        }

        public static bool operator <=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag <= right.Imag;
            return left.Real <= right.Real;
        }

        public static bool operator ==(Complex left, Complex right)
        {
            return left.Real == right.Real && left.Imag == left.Imag;
        }

        public static bool operator !=(Complex left, Complex right)
        {
            return left.Real != right.Real || right.Imag != left.Imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
    }
}
