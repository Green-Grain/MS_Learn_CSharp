using System;

namespace MS_Learn_CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      int fahrenheit = 94;
      Console.WriteLine("The temperature is " + (fahrenheit - 32) * ((decimal)5 / 9) + " Celsius.");
    }
  }
}
