using Demo.Abstraction;
using Demo.Mapping;
using Demo.Operator_Overloading;
using Demo.Partial;
using Demo.Static;


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

            #region Operator Overloading
            // Operator Overloading 

            // + - * / % < > <= >= != == || && ! | & ^  >>

            // +

            //int X = 3 + 4;
            //string Y = "Hello " + "World";

            // Complex Number : Real + Imag

            // 4 + 3 i
            // 4 + 3 ت

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            //Complex C03 = C01 - null;

            //Console.WriteLine(C03);

            //Console.WriteLine(C01);
            //C01++;

            //Console.WriteLine(C01);

            //Console.WriteLine(C01);
            //C01--;

            //Console.WriteLine(C01);

            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01 is greater than C02");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is not greater than C02");
            //} 
            #endregion

            #region User-Defined Casting Operator & Manual Mapping
            // double X = 12;

            // int Y = (int) X;
            // (int) : Casting Operator

            //Complex C01 = new Complex() { Real = 3, Imag = 4};

            //string S = (string)C01;
            // (string) : Convert complex number to string

            // operator overloading
            // User-Defined Casting Operator

            //int X = (int) C01;
            //Console.WriteLine(X);

            //int X = (int)new Complex() { Real = 4, Imag = 3 };

            // Mapping : Convert From Datatype to Datatype

            // Code first
            // DB first

            // User [ id - name - email - password - username - phonenumber - cardnumber - Expiredate ]

            // UserViewModel
            // UserDto
            // [ Name , Email , Password ]


            //User user = new User(); // From DB

            // Manual Mapping
            //UserDto userDto = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,
            //    PhoneNumber = user.PhoneNumber
            //};

            // Casting Operator

            // AutoMapper : Mapping Automatic 
            #endregion

            #region Static
            // Static : C# keyword you can use it with [ Class - Method - Property - Constructor - Attribute ]
            // static class
            // static method 
            // static property
            // static constructor
            // static attribute

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CaToInch(254)); // 100
            //Console.WriteLine(U02.CaToInch(254)); // 100
            //Console.WriteLine(U03.CaToInch(254)); // 100

            //Console.WriteLine(Utilities.CaToInch(254)); // 100
            //Console.WriteLine(Utilities.CaToInch(254)); // 100
            //Console.WriteLine(Utilities.CaToInch(254)); // 100

            //Console.WriteLine(U01.PI);
            //Console.WriteLine(U02.PI);
            //Console.WriteLine(U03.PI);


            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI); 
            #endregion

            #region Sealed
            // Sealed : C# Keyword [ Calsses - Methods - Properties ]  
            #endregion

            #region Partial
            // Partial

            //Employee employee = new Employee();
            //employee. 
            #endregion




        }
    }
}
