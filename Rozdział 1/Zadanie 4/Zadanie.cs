using System;

class Zadanie
{
  public static void Main()
  {
    Console.Write("Wprowadź wartość promienia kuli: ");
    double r = Convert.ToDouble(Console.ReadLine());
    double objetosc = 4 * Math.PI * Math.Pow(r, 3) / 3;
    Console.WriteLine("Objętość kuli o promieniu {0:F2} wynosi: {1:F2}", r, objetosc);
  }
}