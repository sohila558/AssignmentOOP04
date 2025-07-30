using Demo.Abstraction;

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

            Rectangle rectangle = new Rectangle()
            {
                Dim01 = 12,
                Dim02 = 3
            };

            //rectangle.Perimeter = 10;
            Console.WriteLine(rectangle.Perimeter);
            Console.WriteLine(rectangle.GetArea()); 
            #endregion



        }
    }
}
