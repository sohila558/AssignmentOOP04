using Demo.Abstraction;
using Demo.Operator_Overloading;


namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            // 4. Abstraction : 
            // abstract : C# Keyword [Class - Methods - Properties]
            // abstract class
            // abstract method
            // abstract property

            // 2D sahpe


            //Shape shape = new Shape();

            // Note : can't create object from abstract class

            //shape.GetArea();

            //Rectangle rectangle = new Rectangle()
            //{
            //    Dim01 = 12,
            //    Dim02 = 3
            //};

            ////rectangle.Perimeter = 10;
            //Console.WriteLine(rectangle.Perimeter);
            //Console.WriteLine(rectangle.GetArea());
            #endregion

            #region Interface VS Abstract Class
            // Interface VS Abstract Class
            // .NET 3.1 Core 
            #endregion

            // Operator Overloading 

            // + - * / % < > <= >= != == || && ! | & ^  >>

            // +

            //int X = 3 + 4;
            //string Y = "Hello " + "World";

            // Complex Number : Real + Imag
            
            // 4 + 3 i
            // 4 + 3 ت

            Complex C01 = new Complex() { Real = 3, Imag = 4 };
            Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            //Complex C03 = C01 - null;

            //Console.WriteLine(C03);

            //Console.WriteLine(C01);
            //C01++;

            //Console.WriteLine(C01);

            Console.WriteLine(C01);
            C01--;

            Console.WriteLine(C01);






        }
    }
}
