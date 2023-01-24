using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Quel est votre pseudo ?");
      string pseudo = Console.Readline();
      Console.WriteLine("Bonjour {0}", pseudo);
    }
  }
}