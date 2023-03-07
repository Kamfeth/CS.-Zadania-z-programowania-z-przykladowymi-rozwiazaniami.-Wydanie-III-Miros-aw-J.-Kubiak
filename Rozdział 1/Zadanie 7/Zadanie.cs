using System;

class Zadanie
{
  public static void Main()
  {
    Console.Write("Wprowadź pierwszą liczbę: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Wprowadź drugą liczbę: ");
    double y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("{0:F2} + {1:F2} = {2:F2}", x, y, x + y);
    Console.WriteLine("{0:F2} - {1:F2} = {2:F2}", x, y, x - y);
    Console.WriteLine("{0:F2} * {1:F2} = {2:F2}", x, y, x * y);
    Console.WriteLine("{0:F2} / {1:F2} = {2:F2}", x, y, x / y);
  }
}
