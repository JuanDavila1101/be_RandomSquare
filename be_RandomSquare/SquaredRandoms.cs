using System;
using System.Collections.Generic;
namespace be_RandomSquare
{
  class SquaredRandoms
  {
    public List<double> ListOfRandomNumbers { get; set; } = new List<double>();
    public List<double> ListOfRandomSquareNumbers { get; set; } = new List<double>();

    public SquaredRandoms()
    {
      var rand = new Random();
      for (int i = 0; i < 20; i++)
      {
        var number = rand.Next(1, 50);
        ListOfRandomNumbers.Add(number);
        ListOfRandomSquareNumbers.Add(Math.Pow(number, 2));
      }
      PrintListOfNumbers();
    }

    public void PrintListOfNumbers()
    {
      Console.WriteLine($"\nRandom Numbers: {string.Join(',', ListOfRandomNumbers)}");
      Console.WriteLine($"\nRandom Squared Numbers: {string.Join(',', ListOfRandomSquareNumbers)}");
    }

    public void RemoveOddSquaredNumbers()
    {
      ListOfRandomSquareNumbers.RemoveAll(number => number % 2 != 0);
      Console.WriteLine($"\nRandom Squared Numbers: {string.Join(',', ListOfRandomSquareNumbers)}");
    }
  }
}
