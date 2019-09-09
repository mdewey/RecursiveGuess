using System;

namespace RecursiveGuess
{
  class Program
  {
    static int MAX = 100;
    static int MIN = 0;
    static Func<int, int, int> CalculateGuess = (high, low) => (high + low) / 2;
    static void Logic(string input, int guess, int high, int low)
    {
      Action<int> printGuess = g => Console.WriteLine($"Is your number {g}");
      if (input == "stop")
      {
        return;
      }
      else if (input == "yes")
      {
        Console.WriteLine("Awesome!");
      }
      else if (input == "h")
      {
        low = guess;
        guess = CalculateGuess(high, low);
        printGuess(guess);
        Logic(Console.ReadLine(), guess, high, low);
      }
      else if (input == "l")
      {
        high = guess;
        guess = CalculateGuess(high, low);
        printGuess(guess);
        Logic(Console.ReadLine(), guess, high, low);
      }
      else
      {
        printGuess(guess);
        Logic(Console.ReadLine(), guess, high, low);
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Logic(String.Empty, CalculateGuess(MAX, MIN), MAX, MIN);
    }
  }
}
