using System;

namespace MS_Learn_CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Bob";
      int hasBoxesNum = 3;
      decimal temperature = 34.4m;
      Console.Write("Hello, " + name + "! You have " + hasBoxesNum + " in your inbox.");
      Console.Write("  The temperature is " + temperature + " celsius.");
    }
  }
}
