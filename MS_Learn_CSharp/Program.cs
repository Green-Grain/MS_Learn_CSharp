using System;

namespace MS_Learn_CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      string projectName = "ACME";

      string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

      string pathPrefix = @"c:\Exercise\";
      string pathSuffix = @"\data.txt";
      string path = $"{pathPrefix}{projectName}{pathSuffix}";
      Console.WriteLine($"View English output:\n\t\t{path}\n");

      path = $@"{pathPrefix}{projectName}\ru-RU{pathSuffix}";
      Console.WriteLine($"{russianMessage}\n\t\t{path}\n");
    }
  }
}
