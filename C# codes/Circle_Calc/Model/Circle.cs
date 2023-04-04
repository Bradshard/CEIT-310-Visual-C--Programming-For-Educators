using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Area_Perimeter_Create.Model
{
    class Circle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Diameter { get; set; }
        public double Radius { get { return  Diameter / 2; } }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius; //Math.Pow(Radius,2)
        }

        public double CalculatePerimeter()
        {
            return Math.PI * Radius * 2;
        }
        public double CalculatePerimeter(int diameter)
        {
            Diameter = diameter;
            return Math.PI * Radius * 2;
        }
    }
}
