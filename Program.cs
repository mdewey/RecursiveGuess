using System;

namespace RecursiveGuess
{
  class Program
  {
    static int MAX = 100;
    static int MIN = 0;
    static Func<int, int, int> CalculateGuess = (high, low) => (high + low) / 2;
    static Action<int> printGuess = g => Console.WriteLine($"Is your number {g}");

    static void Logic(string input, int guess, int high, int low)
    {
      switch (input.ToLower())
      {
        case var s when s.StartsWith("stop"):
          return;
        case var s when s.StartsWith("yes"):
          Console.WriteLine("Awesome!");
          return;
        case var s when s.StartsWith("h"):
          low = guess;
          guess = CalculateGuess(high, low);
          printGuess(guess);
          Logic(Console.ReadLine(), guess, high, low);
          break;
        case var s when s.StartsWith("l"):
          high = guess;
          guess = CalculateGuess(high, low);
          printGuess(guess);
          Logic(Console.ReadLine(), guess, high, low);
          break;
        case "":
        default:
          printGuess(guess);
          Logic(Console.ReadLine(), guess, high, low);
          break;
      }
    }

    static void Main(string[] args) =>
      Logic(String.Empty, CalculateGuess(MAX, MIN), MAX, MIN);

  }
}
