using System;

class Zadanie
{
  public static void Main()
  {
    Console.Write("Wprowadź pierwszą liczbę: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Wprowadź drugą liczbę: ");
    double y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("{0} + {1} = {2:F2}", x, y, x + y);
    Console.WriteLine("{0} - {1} = {2:F2}", x, y, x - y);
    Console.WriteLine("{0} * {1} = {2:F2}", x, y, x * y);
    Console.WriteLine("{0} / {1} = {2:F2}", x, y, x / y);
  }
}