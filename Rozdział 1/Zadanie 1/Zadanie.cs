using System;

class Zadanie
{
  public static void Main()
  {
    Console.Write("Wprowadź pierwszy bok prostokąta: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Wprowadź drugi bok prostokąta: ");
    double b = Convert.ToDouble(Console.ReadLine());
    double pole = a * b;
    Console.WriteLine("Pole prostokąta jest równe " + pole);
  }
}