using System;

namespace RecursiveGuess
{
  class Program
  {
    static void Logic(string input)
    {
      if (!String.IsNullOrWhiteSpace(input))
      {
        Console.WriteLine("you entered " + input);
      }


      if (input == "stop")
      {
        return;
      }
      else
      {
        Logic(Console.ReadLine());
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Logic(String.Empty);
    }
  }
}
