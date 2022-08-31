using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double length = 36;
      double width = 22;
      
      Console.Write($"The area of a rectangle with a length of {length}ft and a width of {width}ft is: ");
      Console.Write(areaOfRectangle(length, width));
      Console.WriteLine("ft squared.");

    }

    static double areaOfRectangle(double length, double width)
    {
      double area = length * width;
      return area;
    }


  }
}