using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    static class Circle
    {

        static public double DlinaCircle(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static public double SquareCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
        static public  bool ProverkaTochki(double x0, double y0, double x1, double y1, double radius)
        {
            if (Math.Pow((x1 - x0), 2) + Math.Pow((y1 - y0), 2) == Math.Pow(radius, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
