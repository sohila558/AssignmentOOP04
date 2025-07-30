using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract Class : partial class [ Not fully implemented class ] 
    // Concrate Class : Fully Implemented Class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract Method : Like virtual method without implementation
        public abstract double GetArea();

        // Make this method abstract 

        // Abstract Property : Like virtual property without implementation
        public abstract double Perimeter { get; }
    }
}
