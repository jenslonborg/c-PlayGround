using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleApplication
{
    class Rectangle
    {
        // member variables
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
        public void SetDetails(double len, double wth)
        {
            length = len;
            width = wth;
        }
    }
}
