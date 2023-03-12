using System;

class Zadanie
{
  public static void Main()
  {
    Console.Write("Wprowadź wartość pierwszego boku trójkąta: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Wprowadź wartość drugiego boku trójkąta: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Wprowadź wartość trzeciego boku trójkąta: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write("Wprowadzone wartości boków ");
    Console.WriteLine(a * a + b * b == c * c ? "spełniają równanie Pitagorasa" : "nie spełniają równania Pitagorasa");
  }
}