using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double length = 36;
      double width = 22;
      double radius = 16;


      Console.Write($"The area of a rectangle with a length of {length}ft and a width of {width}ft is: ");
      Console.Write(areaOfRectangle(length, width));
      Console.WriteLine("ft squared.");

      Console.Write($"The area of a circle with a radius of {radius}ft is: ");
      Console.Write(areaOfCircle(radius));
      Console.WriteLine("ft squared");

    }

    static double areaOfRectangle(double length, double width)
    {
      double area = length * width;
      return area;
    }

    static double areaOfCircle(double radius)
    {
      double area = Math.PI * Math.Pow(radius, 2);
      return area;
    }

  }
}